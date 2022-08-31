using Flunt.Notifications;
using APIEnem.Domain.Models.Contracts.ValueObjects;
using APIEnem.Domain.Models.ValueObjects.Assertions;

namespace APIEnem.Domain.Models.ValueObjects;

public class Competence : Notifiable, ICompetence
{
    public int Value { get; private set; }

    public Competence(int value)
    {
        Value = value;
        Assert(CompetenceAssertion.CreateCompetenceContract(Value));
    }

    public override string ToString() 
    { 
        return Value.ToString(); 
    }
}
