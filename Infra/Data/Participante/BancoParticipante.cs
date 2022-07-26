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
        public Guid IdentificadorConnection { get; set; }

        private readonly IDataConnection _conexaoBanco;

        public BancoParticipante(IDataConnection conexaoBanco)
        {
            this._conexaoBanco = conexaoBanco;
            this.IdentificadorConnection = conexaoBanco.Identificador;
        }

        public Json BUSCAR_INFORMACOES_DO_PARTICIPANTE(NúmeroInscrição Número)
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
                            dataAdapter.Fill(Data);
                        }

                        if (Data.Rows.Count > 0)
                        {
                            return new Json(Data);
                        }
                        else
                        {
                            throw new RequestException("API:CONTROLLES:PARTICIPANTE:DATABASE_REQUEST:FIND_INSCRICAO:NOT_FOUNDED", "O número de inscrição não consta no banco de dados", "Coloque um número de inscrição validado pelo INEP");
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
