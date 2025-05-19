using Microsoft.Identity.Client;
using System.Security.Principal;
using System;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace BankApi.Models
{
    public class SystemUsers:IdentityUser<int>
    {
   
 
        public virtual DateTime CreatedAT { get; set; }=DateTime.Now;

       


    }
}
