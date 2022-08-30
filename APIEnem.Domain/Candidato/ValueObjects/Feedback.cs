using Flunt.Notifications;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;

namespace APIEnem.Domain.Candidato.ValueObjects;

public class Feedback : Notifiable, IFeedback
{
    public string Value { get; private set; }
    public char[] ValuePerQuestion { get; private set; }

    public Feedback(string feedbackValue)
    {
        Value = feedbackValue;
        ValuePerQuestion = feedbackValue.ToCharArray();
        Assert(FeedbackAssertion.CreateFeedbackContract(Value));
    }
}
