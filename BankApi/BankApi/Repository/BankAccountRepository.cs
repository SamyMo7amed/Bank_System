using BankApi.Models;

namespace BankApi.Repository
{
    public class BankAccountRepository : IRepository<BankAccount>
    {
        public Task AddAsync(BankAccount entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BankAccount>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BankAccount> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(BankAccount entity)
        {
            throw new NotImplementedException();
        }
    }
}
