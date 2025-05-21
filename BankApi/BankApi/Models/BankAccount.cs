using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApi.Models
{

    
    public class BankAccount
    {
   


    public virtual int Id { get; set; } 
     public  virtual int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]   
        
     public virtual Customer Customer { get; set; }
        
     public virtual string AccountNumber { get; set; }  
     public virtual double Balance {  get; set; }    
     
    public virtual DateTime CreatedDate { get; set; } = DateTime.Now;   


      public virtual  Stack<Transaction> Transactions { get; set; }    

    }
}
