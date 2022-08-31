using APIEnem.Domain.Models.Contracts.ValueObjects;
using Flunt.Notifications;

namespace APIEnem.Domain.Request.Participant;

public class Request : Notifiable
{
    public IInscriptionNumber InscriptionNumber { get; private set; }

    public Request(IInscriptionNumber inscriptionNumber)
    {
        InscriptionNumber = inscriptionNumber;
        AddNotifications(inscriptionNumber.Notifications);
    }
}
