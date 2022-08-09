using System.Data;
using Npgsql;

namespace APIEnem.Domain.Models.Interfaces.Database
{
    public interface IGlobalDataActions
    {
        public DataTable? ConverterComandoParaDataTable(NpgsqlCommand Comando);
    }
}
