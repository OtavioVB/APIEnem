using MySql.Data.MySqlClient;

namespace APIEnem.Models.Interfaces
{
    public interface IDataConnection
    {
        public Guid Identificador { get; set; }
        public MySqlConnection Connection { get; set; }
    }
}
