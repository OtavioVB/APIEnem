using Flunt.Notifications;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Domain.Candidato.ValueObjects;

public class IncorrectAnswers : Notifiable, ICorrectOrIncorrectAnswer
{
    public int Value { get; private set; }

    public IncorrectAnswers(int value)
    {
        Value = value;
        Assert(CorrectOrIncorrectAnswerAssertion.CreateAnswerContract(Value));
    }
}