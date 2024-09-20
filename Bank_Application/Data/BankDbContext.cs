using Bank_Application.Models;
using Microsoft.EntityFrameworkCore;
namespace Bank_Application.Data
{
    public class BankDbContext:DbContext
    {

        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options) { }


        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>()
                .HasOne(a => a.User)
                .WithMany(u => u.Accounts)
                .HasForeignKey(a => a.UserId);

            modelBuilder.Entity<Transactions>()
                .HasOne(a => a.Account)
                .WithMany(u => u.Transactions)
                .HasForeignKey(a => a.Id);
        }

    }
}
