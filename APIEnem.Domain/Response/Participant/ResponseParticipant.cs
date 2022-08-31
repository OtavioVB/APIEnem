using Flunt.Notifications;
using APIEnem.Domain.Models.Contracts.Entities;

namespace APIEnem.Domain.Response.Participant;

public class ResponseParticipant : Notifiable
{
    public string Message { get; private set; }
    public IParticipantInformation ParticipantInformation { get; private set; }

    public ResponseParticipant(string message, IParticipantInformation participantInformation)
    {
        Message = message;
        ParticipantInformation = participantInformation;
        AddNotifications(participantInformation.Notifications);
    }

    public ResponseParticipant(string message, IEnumerable<Notification> notifications)
    {
        Message = message;
        AddNotifications(notifications);
    }
}
