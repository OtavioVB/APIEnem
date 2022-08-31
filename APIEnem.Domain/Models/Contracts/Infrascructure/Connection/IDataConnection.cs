using Npgsql;

namespace APIEnem.Domain.Models.Contracts.Infrascructure.Connection;

public interface IDataConnection
{
    public NpgsqlConnection GetConnection();
}
