using Microsoft.EntityFrameworkCore;

namespace MyBank.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Dailer> Dailers { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
        

        public DbSet<Token> Tokens { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().ToTable("cards");
            modelBuilder.Entity<Customer>().ToTable("customers");
            modelBuilder.Entity<Dailer>().ToTable("dailers");
            modelBuilder.Entity<Transaction>().ToTable("transactions");
            modelBuilder.Entity<Token>().ToTable("tokens");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            base.OnConfiguring(optionsBuilder);
        }


    }
}
