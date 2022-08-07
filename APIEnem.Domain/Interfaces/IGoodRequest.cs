using APIEnem.Domain.Models.Candidato;

namespace APIEnem.Domain.Models.Interfaces
{
    public interface IGoodRequest : IStatusRequest
    {
        public ParticipanteData DataResult { get; set; }
    }
}
