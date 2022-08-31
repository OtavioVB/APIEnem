using APIEnem.Domain.Models.Contracts.ValueObjects;
using APIEnem.Domain.Models.ValueObjects.Assertions;
using Flunt.Notifications;

namespace APIEnem.Domain.Models.ValueObjects;

public class Year : Notifiable, IAno
{
    public string Value { get; private set; }

    public Year(string value)
    {
        Value = value;
        Assert(YearAssertion.CreateYearContract(Value));
    }
}
