using APIEnem.Domain.Models.Contracts.ValueObjects;
using Flunt.Notifications;

namespace APIEnem.Domain.Request.Participant;

public class RequestWithInscritiptionNumber : Notifiable
{
    public IInscriptionNumber InscriptionNumber { get; private set; }

    public RequestWithInscritiptionNumber(IInscriptionNumber inscriptionNumber)
    {
        InscriptionNumber = inscriptionNumber;
        AddNotifications(inscriptionNumber.Notifications);
    }
}
