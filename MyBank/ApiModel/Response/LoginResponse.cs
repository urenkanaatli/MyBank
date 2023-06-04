namespace MyBank.ApiModel.Response
{
    public class LoginResponse : BaseReponse
    {


        public string Token { get; set; }

        public DateTime LastDate { get; set; }
    }
}
