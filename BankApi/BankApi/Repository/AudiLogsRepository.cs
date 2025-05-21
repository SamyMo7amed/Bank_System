using BankApi.Models;

namespace BankApi.Repository
{
    public class AudiLogsRepository : IRepository<AuditLogs>
    {
        public  Task AddAsync(AuditLogs entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuditLogs>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AuditLogs> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AuditLogs entity)
        {
            throw new NotImplementedException();
        }
    }
}
