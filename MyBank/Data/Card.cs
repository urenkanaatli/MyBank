namespace MyBank.Data
{
    public class Card
    {

        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string CardNumber { get; set; }

        public int Cvv { get; set; }

        public int LastDate { get; set; }


        public decimal Balance { get; set; }

        public decimal CurrentBlanace { get; set; }
    }
}
