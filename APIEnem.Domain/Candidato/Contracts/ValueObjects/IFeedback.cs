namespace APIEnem.Domain.Candidato.Contracts.ValueObjects;

public interface IFeedback
{
    public string Value { get; }
    public char[] ValuePerQuestion { get; }
}
