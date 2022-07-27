using System.Data;
using APIEnem.Models.Application;
using APIEnem.Models.Candidato;

namespace APIEnem.Models.Interfaces
{
    public interface IDataParticipante
    {
        public Guid Identificador { get;set;}
        public Guid IdentificadorConnection { get; set; }
        ParticipanteData BUSCAR_INFORMACOES_DO_PARTICIPANTE(NúmeroInscrição Número);
    }
}
