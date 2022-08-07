using APIEnem.Domain.Models.Interfaces.Database.Participante;
using APIEnem.Domain.Models.Candidato;
using APIEnem.Domain.Models.Exceptions;
using System.Data;

namespace APIEnem.Infra.Data.Participante
{
    public class ParticipanteActions : GlobalDataActions, IParticipanteDataActions
    {
        public ParticipanteData ConverterDataTableParaParticipanteData(DataTable DataInformacoesBancoDeDados)
        {
            using (DataInformacoesBancoDeDados)
            {
                if (DataInformacoesBancoDeDados != null)
                {
                    foreach (DataRow Linha in DataInformacoesBancoDeDados.Rows)
                    {
                        return new ParticipanteData(
                            new NúmeroInscrição(Linha["NU_INSCRICAO"].ToString()),
                            new Ano(Linha["NU_ANO"].ToString()),
                            new FaixaEtária(Linha["TP_FAIXA_ETARIA"].ToString()),
                            new Sexo(Convert.ToChar(Linha["TP_SEXO"].ToString())),
                            new EstadoCivil(Convert.ToUInt16(Linha["TP_ESTADO_CIVIL"].ToString()), new TiposDeEstadoCivil()),
                            new Exatas(Linha["TX_GABARITO_MT"].ToString(), Linha["TX_RESPOSTAS_MT"].ToString(), Convert.ToDouble(Linha["NU_NOTA_MT"].ToString())),
                            new Naturais(Linha["TX_GABARITO_CN"].ToString(), Linha["TX_RESPOSTAS_CN"].ToString(), Convert.ToDouble(Linha["NU_NOTA_CN"].ToString())),
                            new Humanas(Linha["TX_GABARITO_CH"].ToString(), Linha["TX_RESPOSTAS_CH"].ToString(), Convert.ToDouble(Linha["NU_NOTA_CH"].ToString())),
                            new Linguagens(Linha["TX_GABARITO_LC"].ToString(), Linha["TX_RESPOSTAS_LC"].ToString(), Convert.ToDouble(Linha["NU_NOTA_LC"].ToString())),
                            new Redação(Convert.ToInt16(Linha["NU_NOTA_REDACAO"].ToString()), Convert.ToInt16(Linha["NU_NOTA_COMP1"].ToString()), Convert.ToInt16(Linha["NU_NOTA_COMP2"].ToString()), Convert.ToInt16(Linha["NU_NOTA_COMP3"].ToString()), Convert.ToInt16(Linha["NU_NOTA_COMP4"].ToString()), Convert.ToInt16(Linha["NU_NOTA_COMP5"].ToString()))
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
}
