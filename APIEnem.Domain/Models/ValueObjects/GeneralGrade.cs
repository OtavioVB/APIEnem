using Flunt.Notifications;
using APIEnem.Domain.Models.ValueObjects.Assertions;
using APIEnem.Domain.Models.Contracts.ValueObjects;

namespace APIEnem.Domain.Models.ValueObjects;

public class GeneralGrade : Notifiable, IGeneralGrade
{
    public double Value { get; private set; }

    public GeneralGrade(double value)
    {
        Value = value;
        Assert(GeneralGradeAssertion.CreateGeneralGradeContract(Value));
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}
