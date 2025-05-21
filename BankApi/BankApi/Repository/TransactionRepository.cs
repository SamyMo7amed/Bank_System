using BankApi.Models;

namespace BankApi.Repository
{
    public class TransactionRepository : IRepository<Transaction>
    {
        public Task AddAsync(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
