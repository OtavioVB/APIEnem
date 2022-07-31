using APIEnem.Models.Candidato;

namespace APIEnem.Models.Interfaces
{
    public interface IGoodRequest : IStatusRequest
    {
        public ParticipanteData DataResult { get; set; }
    }
}
