using Npgsql;

namespace APIEnem.Domain.Models.Interfaces
{
    public interface IDataConnection
    {
        public Guid Identificador { get; set; }
        public NpgsqlConnection Connection { get; set; }
    }
}
