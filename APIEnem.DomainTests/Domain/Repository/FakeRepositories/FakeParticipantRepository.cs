using APIEnem.Domain.Models.Contracts.Entities;
using APIEnem.Domain.Models.Contracts.Infrascructure.Persistence.Participant;
using APIEnem.Domain.Models.Contracts.ValueObjects;
using APIEnem.Domain.Models.Entities;
using APIEnem.Domain.Models.ValueObjects;

namespace APIEnem.Tests.Domain.Repository.FakeRepositories;

public class FakeParticipantRepository : IRepositoryParticipant
{
    public IParticipantInformation? GetParticipantDataInformation(IInscriptionNumber inscriptionNumber)
    {
        return null;
    }
}
