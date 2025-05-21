using BankApi.Models;

namespace BankApi.Repository
{
    public class SystemUsersRepository : IRepository<SystemUsers>
    {
        public Task AddAsync(SystemUsers entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SystemUsers>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SystemUsers> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SystemUsers entity)
        {
            throw new NotImplementedException();
        }
    }
}
