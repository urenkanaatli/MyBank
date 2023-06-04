namespace MyBank.ApiModel.Reuest
{
    public class PayRequest
    {

        public string TokenText { get; set; }

        public string CCNumber { get; set; }

        public int Cvv { get; set; }

        public int LastDate { get; set; }


        public decimal Amount { get; set; }

    }
}
