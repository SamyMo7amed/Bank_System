using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BankApi.Models
{

    
    public class BankAccount
    {
   


    public virtual int Id { get; set; } 
     public  virtual int CustomerId { get; set; }   
     public virtual Customer Customer { get; set; }
        
     public virtual string AccountNumber { get; set; }  
     public virtual double Balance {  get; set; }    
     
    public virtual DateTime CreatedDate { get; set; } = DateTime.Now;   


    }
}
