using Flunt.Notifications;
using APIEnem.Domain.Models.ValueObjects.Assertions;
using APIEnem.Domain.Models.Contracts.ValueObjects;

namespace APIEnem.Domain.Models.ValueObjects;

public class InscriptionNumber : Notifiable, IInscriptionNumber
{
    public string Value { get; private set; }

    public InscriptionNumber(string value)
    {
        Value = value;
        Assert(InscriptionNumberAssertion.CreateInscriptionNumberContract(Value));
    }
}