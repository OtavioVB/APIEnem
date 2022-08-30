using Flunt.Notifications;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Domain.Candidato.ValueObjects;

public class CompetenceAverage : Notifiable, ICompetenceAverage
{
    public int Value { get; private set; }

    public CompetenceAverage(int value)
    {
        Value = value;
        Assert(CompetenceAverageAssertion.CreateCompetenceAverageContract(Value));
    }
}
