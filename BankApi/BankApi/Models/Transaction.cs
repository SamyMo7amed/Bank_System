using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;

namespace BankApi.Models
{

    public class Transaction
    {

    //Amount DECIMAL(18,2),
    //TransactionType NVARCHAR(50), -- إيداع، سحب، تحويل
    //TransactionDate DATETIME

        public virtual int Id { get; set; }
        
     public virtual  int FromAccountId { get; set; } 

    public virtual BankAccount FromAccount { get; set; }    
    public virtual int ToAccountId { get; set; } = 0;


     public virtual BankAccount ToAccount { get;set; }

     public virtual double Amount { get; set; } 


        public virtual int TransactionTypeId {  get; set; } 
     
      public virtual TransactionType TransactionType { get; set; }




    }
}
