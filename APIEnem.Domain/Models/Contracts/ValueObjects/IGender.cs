
namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface IGender : IObjectNotification
{
    public string Text { get; }
    public char AlphaNumeric { get; }
}
