namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface ICorrectOrIncorrectAnswer : IObjectNotification
{
    public int Value { get; }
}
