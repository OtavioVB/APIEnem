using APIEnem.Domain.Models.Contracts.Infrascructure.Connection;
using Npgsql;

namespace APIEnem.Domain.Repositories.Connection;

public class DataConnection : IDataConnection
{
    private readonly NpgsqlConnection _connection;

    public DataConnection()
    {
        try
        {
            _connection = new NpgsqlConnection(Environment.GetEnvironmentVariable("POSTGREE_CONNECTION_STRING"));
        }
        catch
        {
            throw new Exception("INTERNAL ERROR: Não foi possível se conectar ao banco de dados!");
        }
    }

    public NpgsqlConnection GetConnection()
    {
        return _connection;
    }
}
