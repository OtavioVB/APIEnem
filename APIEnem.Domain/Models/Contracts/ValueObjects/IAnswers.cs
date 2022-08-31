namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface IAnswers : IObjectNotification
{
    public string Value { get; }
    public char[] ValuePerQuestion { get; }
}
