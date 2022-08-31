using APIEnem.Domain.Models.Contracts.Infrascructure.Persistence.Participant;
using APIEnem.Domain.Request.Participant;
using APIEnem.Domain.Response.Participant;
using Flunt.Notifications;

namespace APIEnem.Domain.Handlers;

public class ParticipantHandler : Notifiable
{
    private readonly IRepositoryParticipant _repositoryParticipant;

    public ParticipantHandler(IRepositoryParticipant repositoryParticipant)
    {
        _repositoryParticipant = repositoryParticipant;
    }

    public ResponseParticipant Handle(RequestWithInscritiptionNumber request)
    {
        if (request.IsValid is false) return new ResponseParticipant("A requisição é inválida!", request.Notifications);


        return new ResponseParticipant("Requisição realizada com sucesso!");
    }
}
