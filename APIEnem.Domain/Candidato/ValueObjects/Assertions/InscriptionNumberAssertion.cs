using Flunt.Validations;

namespace APIEnem.Domain.Candidato.ValueObjects.Assertions;

public static class InscriptionNumberAssertion
{
    public static Contract CreateInscriptionNumberContract(string inscriptionNumber)
    {
        return new Contract()
            .NotMatches(inscriptionNumber, @"^[0-9]{12}$", "InscriptionNumberRegexNumber.Value", "O valor do número de inscrição não é válido Ex.: 000000000000");
    }
}
