namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface IInscriptionNumber : IObjectNotification
{
    public string Value { get; }
}
