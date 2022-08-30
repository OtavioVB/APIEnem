using APIEnem.Domain.Candidato.Contracts.ValueObjects;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;
using Flunt.Notifications;

namespace APIEnem.Domain.Candidato.ValueObjects;

public class Year : Notifiable, IAno
{
    public string Value { get; private set; }

    public Year(string value)
    {
        Value = value;
        Assert(YearAssertion.CreateYearContract(Value));
    }
}
