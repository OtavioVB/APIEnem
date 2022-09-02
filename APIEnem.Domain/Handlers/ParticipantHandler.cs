using APIEnem.Domain.Models.Contracts.Infrascructure.Persistence.Participant;
using APIEnem.Domain.Request.Participant;
using APIEnem.Domain.Response.Participant;
using APIEnem.Domain.Models.Contracts.Handlers;
using Flunt.Notifications;

namespace APIEnem.Domain.Handlers;

public class ParticipantHandler : Notifiable, IParticipantHandler
{
    private readonly IRepositoryParticipant _repositoryParticipant;

    public ParticipantHandler(IRepositoryParticipant repositoryParticipant)
    {
        _repositoryParticipant = repositoryParticipant;
    }

    public ResponseParticipant Handle(RequestWithInscritiptionNumber request)
    {
        if (request.IsValid is false) return new ResponseParticipant("A requisição é inválida!", request.Notifications);

        var dataQuery = _repositoryParticipant.GetParticipantDataInformation(request.InscriptionNumber);

        if (dataQuery == null) 
        { 
            var response = new ResponseParticipant("A requisição é inválida!");
            response.AddNotification("InscriptionNumber.NotFounded.Value", "Não foi possível encontrar esse número de inscrição no banco de dados.");
            return response;
        }

        return new ResponseParticipant("Requisição realizada com sucesso!", dataQuery);
    }
}
