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
            _connection = new NpgsqlConnection("Host=ec2-34-193-44-192.compute-1.amazonaws.com;Database=dda1082kmph9ki;user id=ystpdhdsqnubxp;pwd=b3d160a53e257dda61c23cf596f0b44b42734eaed488b0273a37c41c43aa0936;port=5432");
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
