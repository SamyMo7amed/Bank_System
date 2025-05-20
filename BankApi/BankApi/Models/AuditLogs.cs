namespace BankApi.Models
{
    public class AuditLogs
    {
        public virtual int Id { get; set; } 

        public virtual SystemUsers User { get; set; }

        public virtual string Action { get; set; }  

        public virtual DateTime CreatedDate { get; set; }   


    }
}
