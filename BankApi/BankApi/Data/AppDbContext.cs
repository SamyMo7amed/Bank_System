using BankApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BankApi.Data
{
    public class AppDbContext : IdentityDbContext<SystemUsers,IdentityRole<int>,int>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BankAccount>().HasOne(x => x.Customer).WithOne().HasForeignKey<BankAccount>(x=>x.CustomerId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Transaction>().HasOne(x=>x.TransactionType).WithOne().HasForeignKey<Transaction>(t=>t.TransactionTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Transaction>().HasOne(x=>x.FromAccount).WithMany(x=>x.Transactions).HasForeignKey(x=>x.FromAccountId).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Transaction>().HasOne(x => x.ToAccount).WithMany(x=>x.Transactions).HasForeignKey(x => x.ToAccountId).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<BankAccount>().Property(x=>x.Balance).HasPrecision(18,2);
            builder.Entity<Transaction>().Property(x=>x.Amount).HasPrecision(18,2);
           
        }

        public DbSet<AuditLogs> AuditLogs { get; set; }         
        public DbSet<BankAccount> BankAccounts { get; set; }                
        public DbSet<Customer> Customers { get; set; }  
        public DbSet<SystemUsers> SystemUsers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }    
        public DbSet<TransactionType> transactionTypes { get; set; }


    }
}
