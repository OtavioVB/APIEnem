using APIEnem.Domain.Models.Contracts.Entities;
using APIEnem.Domain.Models.Contracts.ValueObjects;

namespace APIEnem.Domain.Models.Contracts.Infrascructure.Persistence.Participant;

public interface IRepositoryParticipant
{
    public IParticipantInformation? GetParticipantDataInformation(IInscriptionNumber inscriptionNumber);
}
