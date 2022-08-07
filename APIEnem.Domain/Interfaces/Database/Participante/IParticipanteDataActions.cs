using APIEnem.Domain.Models.Candidato;
using System.Data;

namespace APIEnem.Domain.Models.Interfaces.Database.Participante
{
    public interface IParticipanteDataActions : IGlobalDataActions
    {
        public ParticipanteData ConverterDataTableParaParticipanteData(DataTable DataInformacoesBancoDeDados);
    }
}
