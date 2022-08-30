using Flunt.Notifications;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Domain.Candidato.ValueObjects;

public class InscriptionNumber : Notifiable, IInscriptionNumber
{
    public string Value { get; private set; }

    public InscriptionNumber(string value)
    {
        Value = value;
        Assert(InscriptionNumberAssertion.CreateInscriptionNumberContract(Value));
    }
}