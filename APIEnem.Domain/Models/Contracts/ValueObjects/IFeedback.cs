namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface IFeedback
{
    public string Value { get; }
    public char[] ValuePerQuestion { get; }
}
