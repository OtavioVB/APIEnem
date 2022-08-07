using MySql.Data.MySqlClient;
using APIEnem.Domain.Models.Interfaces;
using APIEnem.Domain.Models.Exceptions;

namespace APIEnem.Infra.Data
{
    public class Conexão : IDataConnection
    {
        public Guid Identificador { get; set; } = Guid.NewGuid();
        public MySqlConnection Connection { get; set; }

        public Conexão()
        {
            try
            {
                Connection = new MySqlConnection("server=127.0.0.1;database=enem_microdata;uid=otavio;pwd=1234;port=3306");
            }
            catch
            {
                throw new RequestException("API:INFRA:DATA:DATABASE_CONNECTION", "Não foi possível se conectar ao banco de dados", "Contate o suporte para resolução do problema");
            }
        }
    }
}
