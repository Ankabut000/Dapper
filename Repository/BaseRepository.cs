using ConsoleApp1.Constants;
using Npgsql;

namespace ConsoleApp1.Repository;

public abstract class BaseRepository
{
    protected readonly NpgsqlConnection _connection;

    public BaseRepository()
    {
        _connection = new NpgsqlConnection(Dbconstants.DB_CONNACTIONSTRING);
    }
}
