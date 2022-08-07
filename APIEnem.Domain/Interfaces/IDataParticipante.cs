using APIEnem.Domain.Models.Candidato;

namespace APIEnem.Domain.Models.Interfaces
{
    public interface IDataParticipante
    {
        public Guid Identificador { get;set;}
        public Guid IdentificadorConnection { get; set; }
        ParticipanteData BuscarInformaçõesDoParticipante(NúmeroInscrição Número);
    }
}
