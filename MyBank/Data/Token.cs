namespace MyBank.Data
{
    public class Token
    {

        public int Id { get; set; }

        public string TokenText  { get; set; }

        public DateTime EndDate { get; set; }


        public int DailerId { get; set; }

        public Dailer Dailer { get; set; }
    }
}
