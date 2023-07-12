using ConsoleApp1.Entities.Students;

namespace ConsoleApp1.Interfaces.Students
{
    public interface IStudentRepository : IRepository<Student>
    {
        public Task<int> GetWithIdAsync(long id);

    }
}
