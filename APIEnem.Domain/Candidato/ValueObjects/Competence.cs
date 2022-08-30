using Flunt.Notifications;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;

namespace APIEnem.Domain.Candidato.ValueObjects;

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
