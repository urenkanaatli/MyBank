using System.ComponentModel.DataAnnotations;

namespace MyBank.Data
{
    public class Transaction
    {
        public int Id { get; set; }

        public int CardId { get; set; }

        public Card Card { get; set; }

        public decimal Balance { get; set; }

        public int DailerId { get; set; }

        public Dailer Dailer { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Description { get; set; }
    }
}
