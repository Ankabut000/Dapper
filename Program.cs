
using ConsoleApp1.Entities.Clients;
using ConsoleApp1.Entities.Employees;
using ConsoleApp1.Entities.Students;
using ConsoleApp1.Forms;
using ConsoleApp1.MainForms;

namespace ConsoleApp1;

public class Program
{
    static async Task Main()
    {
        await ClientIsStarted();
        await StudentIsStarted();
        await EmployeeIsStarted();

    }

    static async Task ClientIsStarted()
    {
        var formClient = new FormClient();

        var newClient = new Client
        {
            FirstName = "Anvar",
            LastName = "Farhodov"
        };

        // CREATE 
        int createResult = await formClient.CreateAsync(newClient);
        Console.WriteLine($"Create result: {createResult}");

        var existingClient = new Client
        {
            Id = 1,
            FirstName = "Dilshod",
            LastName = "Rashidov"
        };

        // UPDATE
        int updateResult = await formClient.UpdateAsync(existingClient);
        Console.WriteLine($"Update result: {updateResult}");

        // DELETE
        int deleteResult = await formClient.DeleteAsync(2);
        Console.WriteLine($"Delete result: {deleteResult}");
    }


    static async Task StudentIsStarted()
    {
        var formStudent = new FormStudent();

        var newStudent = new Student
        {
            FirstName = "Anvar",
            LastName = "Farhodov"
        };

        // CREATE 
        int createResult = await formStudent.CreateAsync(newStudent);
        Console.WriteLine($"Create result: {createResult}");

        var existingClient = new Student
        {
            Id = 1,
            FirstName = "Dilshod",
            LastName = "Rashidov"
        };

        // UPDATE
        int updateResult = await formStudent.UpdateAsync(existingClient);
        Console.WriteLine($"Update result: {updateResult}");

        // DELETE
        int deleteResult = await formStudent.DeleteAsync(2);
        Console.WriteLine($"Delete result: {deleteResult}");
    }

    static async Task EmployeeIsStarted()
    {
        var formEmployee = new FormEmployee();

        var newEmployee = new Employee
        {
            FirstName = "Anvar",
            LastName = "Farhodov"
        };

        // CREATE 
        int createResult = await formEmployee.CreateAsync(newEmployee);
        Console.WriteLine($"Create result: {createResult}");

        var existingClient = new Employee
        {
            Id = 1,
            FirstName = "Dilshod",
            LastName = "Rashidov"
        };

        // UPDATE
        int updateResult = await formEmployee.UpdateAsync(existingClient);
        Console.WriteLine($"Update result: {updateResult}");

        // DELETE
        int deleteResult = await formEmployee.DeleteAsync(2);
        Console.WriteLine($"Delete result: {deleteResult}");
    }

}