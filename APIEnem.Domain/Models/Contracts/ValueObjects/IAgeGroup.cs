namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface IAgeGroup : IObjectNotification
{
    int Code { get; }
    string Text { get; }
}
