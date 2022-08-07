using APIEnem.Domain.Models.Interfaces.Database;
using System.Data;
using MySql.Data.MySqlClient;

namespace APIEnem.Infra.Data
{
    public class GlobalDataActions : IGlobalDataActions
    {
        public DataTable? ConverterComandoParaDataTable(MySqlCommand comando)
        {
            using (comando)
            {
                using (DataTable dataResultadoComandoSql = new())
                {
                    using (MySqlDataAdapter dadosAdaptadosParaDataTable = new(comando))
                    {
                        dadosAdaptadosParaDataTable.Fill(dataResultadoComandoSql);

                        return dataResultadoComandoSql.Rows.Count > 0 ? dataResultadoComandoSql : null; 
                    }
                }
            }
        }
    }
}
