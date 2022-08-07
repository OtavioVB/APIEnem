using System.Data;
using MySql.Data.MySqlClient;

namespace APIEnem.Domain.Models.Interfaces.Database
{
    public interface IGlobalDataActions
    {
        public DataTable? ConverterComandoParaDataTable(MySqlCommand Comando);
    }
}
