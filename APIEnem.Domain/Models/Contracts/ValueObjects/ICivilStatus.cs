namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface ICivilStatus : IObjectNotification
{
    public int Code { get; }
    public string Text { get; }
}
