namespace MyBank.Data
{
    public class Customer
    {
        public int Id { get; set; }

        public string NameSurname { get; set; }

        public string TC { get; set; }

        public ICollection<Card> Cards { get; set; }



    }
}
