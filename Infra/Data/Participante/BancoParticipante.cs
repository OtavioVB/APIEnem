using MySql.Data.MySqlClient;
using System.Data;
using APIEnem.Models.Interfaces;
using APIEnem.Models.Candidato;
using APIEnem.Models.Application;
using APIEnem.Models.Exceptions;

namespace APIEnem.Infra.Data.Participante
{
    public class BancoParticipante : IDataParticipante
    {
        public Guid Identificador { get; set; } = Guid.NewGuid();

        private readonly IDataConnection _conexaoBanco;

        public BancoParticipante(IDataConnection conexaoBanco)
        {
            this._conexaoBanco = conexaoBanco;
        }

        public async Task<Json> BUSCAR_INFORMACOES_DO_PARTICIPANTE(NúmeroInscrição Número)
        {
            try
            {
                using (MySqlCommand Comando = _conexaoBanco.ConectarBanco().CreateCommand())
                {
                    Comando.CommandText = "SELECT * FROM TB_DADOS WHERE NU_INSCRICAO = @NúmeroDeInscrição";
                    Comando.Parameters.AddWithValue("@NúmeroDeInscrição", Número.ToString());
                    using (DataTable Data = new DataTable())
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Comando))
                        {
                            await dataAdapter.FillAsync(Data);
                        }

                        if (Data.Rows.Count > 0)
                        {
                            return new Json(Data);
                        }
                        else
                        {
                            throw new RequestException("O código do participante inserido não consta no banco de dados.");
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
