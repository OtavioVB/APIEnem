namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface IFeedback : IObjectNotification
{
    public string Value { get; }
    public char[] ValuePerQuestion { get; }
}
