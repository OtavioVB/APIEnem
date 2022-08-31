namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface IAnswers
{
    public string Value { get; }
    public char[] ValuePerQuestion { get; }
}
