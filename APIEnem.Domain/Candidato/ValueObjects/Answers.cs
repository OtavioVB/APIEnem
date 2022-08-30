using Flunt.Notifications;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;

namespace APIEnem.Domain.Candidato.ValueObjects;

public class Answers : Notifiable, IAnswers
{
    public string Value { get; private set; }
    public char[] ValuePerQuestion { get; private set; }

    public Answers(string answersValue)
    {
        Value = answersValue;
        ValuePerQuestion = answersValue.ToCharArray();
        Assert(AnswersAssertion.CreateAnswersContract(Value));
    }
}
