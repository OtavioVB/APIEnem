namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface IYear : IObjectNotification
{
    public string Value { get; }
}