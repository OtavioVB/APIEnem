using Npgsql;

namespace APIEnem.Infra.Data.Contracts.Connection;

public interface IDataConnection
{
    public NpgsqlConnection GetConnection();
}
