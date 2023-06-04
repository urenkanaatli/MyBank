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
    public class AutenticationController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public AutenticationController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {

            var dailer = await _applicationDbContext.Dailers.FirstOrDefaultAsync(t => t.UserName == request.UserName && t.Password == request.Password);

            if (dailer == null)
            {
                return Unauthorized(new LoginResponse
                {
                    Error = "Kullanıcı adı veya şifre hatali"
                });
            }

            var token = new Token
            {
                TokenText = DateTime.Now.Ticks.ToString(),
                DailerId = dailer.Id,
                EndDate = DateTime.Now.AddMinutes(4)
            };


            await _applicationDbContext.Tokens.AddAsync(token);
            await _applicationDbContext.SaveChangesAsync();


            return Ok(new LoginResponse
            {
                LastDate = token.EndDate,
                Token = token.TokenText
            });
        }
    }
}
