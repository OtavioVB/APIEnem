using APIEnem.Models.Interfaces.Database;
using System.Data;
using MySql.Data.MySqlClient;

namespace APIEnem.Infra.Data
{
    public class GlobalDataActions : IGlobalDataActions
    {
        public DataTable ConverterComandoParaDataTable(MySqlCommand Comando)
        {
            using (Comando)
            {
                using (DataTable DataResultadoComandoSql = new())
                {
                    using (MySqlDataAdapter DadosAdaptadosParaDataTable = new(Comando))
                    {
                        DadosAdaptadosParaDataTable.Fill(DataResultadoComandoSql);

                        if (DataResultadoComandoSql.Rows.Count > 0 is true) return DataResultadoComandoSql;
                        return null;
                    }
                }
            }
        }
    }
}
