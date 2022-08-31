using APIEnem.Domain.Request.Participant;
using APIEnem.Domain.Response.Participant;

namespace APIEnem.Domain.Models.Contracts.Handlers;

public interface IParticipantHandler
{
    public ResponseParticipant Handle(RequestWithInscritiptionNumber request);
}
