using System.Data;
using MySql.Data.MySqlClient;

namespace APIEnem.Models.Interfaces.Database
{
    public interface IGlobalDataActions
    {
        public DataTable ConverterComandoParaDataTable(MySqlCommand Comando);
    }
}
