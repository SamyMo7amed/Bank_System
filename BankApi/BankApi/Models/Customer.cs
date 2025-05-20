using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApi.Models
{
    public class Customer : SystemUsers
    {



        public virtual string NationalId { get; set; }
        public  virtual string Nationality { get; set; }    
        

       public virtual  string ImageFrontIdCard {  get; set; }   

      public virtual string ImageBackIdCard { get; set; }
      

        public virtual BankAccount BankAccount { get; set; }    

        

    
    }
}
