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

        public ParticipanteData BUSCAR_INFORMACOES_DO_PARTICIPANTE(NúmeroInscrição Número)
        {
            try
            {
                using (MySqlCommand Comando = _conexaoBanco.Connection.CreateCommand())
                {
                    Comando.CommandText = "SELECT * FROM TB_DADOS WHERE NU_INSCRICAO = @NúmeroDeInscrição LIMIT 1;";
                    Comando.Parameters.AddWithValue("@NúmeroDeInscrição", Número.ToString());
                    using (DataTable Data = new DataTable())
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Comando))
                        {
                            dataAdapter.Fill(Data);
                        }

                        if (Data.Rows.Count > 0)
                        {
                            foreach (DataRow Linha in Data.Rows)
                            {
                                return new ParticipanteData(
                                    Número, 
                                    new Ano(Linha["NU_ANO"].ToString()), 
                                    new FaixaEtária(Linha["TP_FAIXA_ETARIA"].ToString()), 
                                    new Sexo(Convert.ToChar(Linha["TP_SEXO"].ToString())), 
                                    new EstadoCivil(Convert.ToUInt16(Linha["TP_ESTADO_CIVIL"].ToString()), new TiposDeEstadoCivil()),
                                    new Exatas(Linha["TX_GABARITO_MT"].ToString(), Linha["TX_RESPOSTAS_MT"].ToString()),
                                    new Naturais(Linha["TX_GABARITO_CN"].ToString(), Linha["TX_RESPOSTAS_CN"].ToString()),
                                    new Humanas(Linha["TX_GABARITO_CH"].ToString(), Linha["TX_RESPOSTAS_CH"].ToString()),
                                    new Linguagens(Linha["TX_GABARITO_LC"].ToString(), Linha["TX_RESPOSTAS_LC"].ToString())
                                    );
                                break;
                            }
                            throw new RequestException("API:CONTROLLES:PARTICIPANTE:DATABASE_REQUEST:FIND_INSCRICAO:OUT_FOREACH", "O número de inscrição não consta no banco de dados", "Coloque um número de inscrição validado pelo INEP");
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
