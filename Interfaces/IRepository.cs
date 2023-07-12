using ConsoleApp1.Entities.Clients;

namespace ConsoleApp1.Interfaces
{
    public interface IRepository<TEntity>
    {
        public Task<int> CreateAsync(TEntity obj);
        public Task<int> UpdateAsync(TEntity obj);
        public Task<int> DeleteAsync(long id);
        public Task<int> GetByIdAsync(long id);
        public Task<string> GetByNameAsync(string name);
    }
}
