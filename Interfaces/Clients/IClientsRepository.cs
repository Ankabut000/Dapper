using ConsoleApp1.Entities.Clients;

namespace ConsoleApp1.Interfaces.Clients
{
    public interface IClientsRepository : IRepository<Client>
    {
        public Task<int> GetWithIdAsync(long id);
    }
}
