using ConsoleApp1.Entities.Clients;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Repository;
using Dapper;

namespace ConsoleApp1.MainForms;

public class FormClient : BaseRepository, IRepository<Client>
{
    public async Task<int> CreateAsync(Client obj)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "INSERT INTO public.clients(firstname, lastname) VALUES (@FirstName, @LastName);";
            var result = await _connection.ExecuteAsync(query, obj);
            return result;
        }
        catch
        {
            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<int> DeleteAsync(long id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "DELETE FROM public.clients WHERE id = @Id;";
            var result = await _connection.ExecuteAsync(query, new { Id = id });
            return result;
        }
        catch
        {
            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public Task<int> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetByNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<int> UpdateAsync(Client obj)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"UPDATE public.clients SET firstname = @FirstName, lastname = @LastName WHERE id = @Id;";
            var result = await _connection.ExecuteAsync(query, obj);
            return result;
        }
        catch
        {
            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }
}


