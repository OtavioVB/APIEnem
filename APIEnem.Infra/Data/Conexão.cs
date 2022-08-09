using Npgsql;
using APIEnem.Domain.Models.Interfaces;
using APIEnem.Domain.Models.Exceptions;

namespace APIEnem.Infra.Data
{
    public class Conexão : IDataConnection
    {
        public Guid Identificador { get; set; } = Guid.NewGuid();
        public NpgsqlConnection Connection { get; set; }

        public Conexão()
        {
            try
            {
                Connection = new NpgsqlConnection(Environment.GetEnvironmentVariable("POSTGREE_CONNECTION_STRING"));
            }
            catch
            {
                throw new RequestException("API:INFRA:DATA:DATABASE_CONNECTION", "Não foi possível se conectar ao banco de dados", "Contate o suporte para resolução do problema");
            }
        }
    }
}
