using APIEnem.Domain.Models.Interfaces.Database;
using System.Data;
using Npgsql;

namespace APIEnem.Infra.Data
{
    public class GlobalDataActions : IGlobalDataActions
    {
        public DataTable? ConverterComandoParaDataTable(NpgsqlCommand comando)
        {
            using (comando)
            {
                using (DataTable dataResultadoComandoSql = new())
                {
                    using (NpgsqlDataAdapter dadosAdaptadosParaDataTable = new(comando))
                    {
                        dadosAdaptadosParaDataTable.Fill(dataResultadoComandoSql);
                        return dataResultadoComandoSql.Rows.Count > 0 ? dataResultadoComandoSql : null; 
                    }
                }
            }
        }
    }
}
