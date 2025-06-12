using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApi.Models
{

    public class Transaction
    {

    
        public virtual int Id { get; set; }
        
     public virtual  int FromAccountId { get; set; }
        [ForeignKey(nameof(FromAccount))]

    public virtual BankAccount FromAccount { get; set; }    
    public virtual int ToAccountId { get; set; } 

        [ForeignKey(nameof(ToAccount))]
     public virtual BankAccount ToAccount { get;set; }

     public virtual double Amount { get; set; } 


     public virtual int TransactionTypeId {  get; set; }
        [ForeignKey(nameof(TransactionTypeId))]  
      
      public virtual TransactionType TransactionType { get; set; }




    }
}
