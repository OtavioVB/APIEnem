using Flunt.Notifications;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Domain.Candidato.ValueObjects;

public class CorrectAnswers : Notifiable, ICorrectOrIncorrectAnswer
{
    public int Value { get; private set; }

    public CorrectAnswers(int value)
    {
        Value = value;
        Assert(CorrectOrIncorrectAnswerAssertion.CreateAnswerContract(Value));
    }
}
