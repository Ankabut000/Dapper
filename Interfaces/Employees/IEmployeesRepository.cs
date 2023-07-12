using ConsoleApp1.Entities.Employees;

namespace ConsoleApp1.Interfaces.Employees;
public interface IEmployeesRepository : IRepository<Employee>
{
    public Task<int> GetWithIdAsync(long id);

}
