using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBank.ApiModel.Response;
using MyBank.ApiModel.Reuest;
using MyBank.Data;

namespace MyBank.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PaymentController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

        }


        [HttpPost]
        public async Task<IActionResult> Pay(PayRequest request)
        {

            var dbtoken =await _applicationDbContext.Tokens.FirstOrDefaultAsync(t => t.TokenText == request.TokenText);

            if (dbtoken == null || dbtoken.EndDate < DateTime.Now)
            {
                return Unauthorized();
            }

           

            var creditCard = _applicationDbContext.Cards.FirstOrDefault(t => t.CardNumber == request.CCNumber.Replace("-","") && t.Cvv == request.Cvv && t.LastDate == request.LastDate);


            if (creditCard == null)
            {

                return NotFound(new PayResponse
                {
                    Error = "CREDİT CARD not found!!"
                });
            }


            if (creditCard.CurrentBlanace < request.Amount)
            {
                return StatusCode(500, new PayResponse
                {
                    Error = "Yetersiz Bakiye"
                });
            }



            creditCard.CurrentBlanace = creditCard.CurrentBlanace - request.Amount;

            var transaction = new MyBank.Data.Transaction
            {
                Balance = request.Amount,
                CardId = creditCard.Id,
                DailerId = dbtoken.DailerId,
                TransactionDate = DateTime.Now,
                Description = "Odeme alındı"
            };

            await _applicationDbContext.Transactions.AddAsync(transaction);
            await _applicationDbContext.SaveChangesAsync();


            return Ok();

        }

    }
}
