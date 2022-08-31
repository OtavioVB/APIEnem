using Flunt.Notifications;
using APIEnem.Domain.Models.ValueObjects.Assertions;
using APIEnem.Domain.Models.Contracts.ValueObjects;

namespace APIEnem.Domain.Models.ValueObjects;

public class CorrectAnswers : Notifiable, ICorrectOrIncorrectAnswer
{
    public int Value { get; private set; }

    public CorrectAnswers(int value)
    {
        Value = value;
        Assert(CorrectOrIncorrectAnswerAssertion.CreateAnswerContract(Value));
    }
}
