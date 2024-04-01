using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Infrastracture.DataContext;

public class DapperContext
{
    private readonly string connectionString = "Host=localhost,Port=5432;Database=bankdb;User id=postgres;Password=akmaljon2008";

    

    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(connectionString);
    }
}