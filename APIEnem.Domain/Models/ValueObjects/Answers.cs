using Flunt.Notifications;
using APIEnem.Domain.Models.Contracts.ValueObjects;
using APIEnem.Domain.Models.ValueObjects.Assertions;

namespace APIEnem.Domain.Models.ValueObjects;

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
