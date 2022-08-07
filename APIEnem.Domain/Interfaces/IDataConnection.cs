using MySql.Data.MySqlClient;

namespace APIEnem.Domain.Models.Interfaces
{
    public interface IDataConnection
    {
        public Guid Identificador { get; set; }
        public MySqlConnection Connection { get; set; }
    }
}
