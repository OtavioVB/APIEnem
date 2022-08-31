using Flunt.Notifications;
using APIEnem.Domain.Models.ValueObjects.Assertions;
using APIEnem.Domain.Models.Contracts.ValueObjects;

namespace APIEnem.Domain.Models.ValueObjects;

public class CompetenceAverage : Notifiable, ICompetenceAverage
{
    public int Value { get; private set; }

    public CompetenceAverage(int value)
    {
        Value = value;
        Assert(CompetenceAverageAssertion.CreateCompetenceAverageContract(Value));
    }
}
