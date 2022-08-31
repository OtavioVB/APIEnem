using APIEnem.Domain.Models.Contracts.Infrascructure.Persistence.Participant;

namespace APIEnem.Domain.Handlers;

public class ParticipantHandler
{
    private readonly IRepositoryParticipant _repositoryParticipant;

    public ParticipantHandler(IRepositoryParticipant repositoryParticipant)
    {
        _repositoryParticipant = repositoryParticipant;
    }
}
