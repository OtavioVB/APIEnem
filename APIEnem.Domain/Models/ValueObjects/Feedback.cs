using Flunt.Notifications;
using APIEnem.Domain.Models.Contracts.ValueObjects;
using APIEnem.Domain.Models.ValueObjects.Assertions;

namespace APIEnem.Domain.Models.ValueObjects;

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
