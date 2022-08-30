namespace APIEnem.Domain.Candidato.Contracts.ValueObjects;

public interface IAnswers
{
    public string Value { get; }
    public char[] ValuePerQuestion { get; }
}
