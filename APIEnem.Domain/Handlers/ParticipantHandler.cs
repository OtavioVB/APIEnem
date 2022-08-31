using APIEnem.Domain.Models.Contracts.Infrascructure.Persistence.Participant;
using APIEnem.Domain.Models.Contracts.Entities;
using Flunt.Notifications;

namespace APIEnem.Domain.Handlers;

public class ParticipantHandler : Notifiable
{
    private readonly IRepositoryParticipant _repositoryParticipant;

    public ParticipantHandler(IRepositoryParticipant repositoryParticipant)
    {
        _repositoryParticipant = repositoryParticipant;
    }

    public IParticipantInformation? Handle()
    {
        return null;
    }
}
