
using ConsoleApp1.Entities.Clients;
using ConsoleApp1.MainForms;

namespace ConsoleApp1;

public class Program
{
    static async Task Main()
    {
        var myClass = new FromClient();

        var newClient = new Client { FirstName = "John", LastName = "Doe" };

        int createResult = await myClass.CreateAsync(newClient);
        Console.WriteLine($"Create result: {createResult}");

        var existingClient = new Client
        {
            Id = 1,
            FirstName = "Jane",
            LastName = "Doe"
        };

        int updateResult = await myClass.UpdateAsync(existingClient);
        Console.WriteLine($"Update result: {updateResult}");

        int deleteResult = await myClass.DeleteAsync(2);
        Console.WriteLine($"Delete result: {deleteResult}");
    }

}