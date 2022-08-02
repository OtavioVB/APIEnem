using APIEnem.Models.Candidato;
using System.Data;

namespace APIEnem.Models.Interfaces.Database.Participante
{
    public interface IParticipanteDataActions : IGlobalDataActions
    {
        public ParticipanteData ConverterDataTableParaParticipanteData(DataTable DataInformacoesBancoDeDados);
    }
}
