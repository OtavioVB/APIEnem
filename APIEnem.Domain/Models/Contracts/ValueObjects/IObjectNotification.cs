using Flunt.Notifications;

namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface IObjectNotification
{
    public IReadOnlyCollection<Notification> Notifications { get; }
    public bool IsValid { get; }
}
