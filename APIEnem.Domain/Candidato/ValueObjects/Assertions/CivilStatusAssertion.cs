using Flunt.Validations;

namespace APIEnem.Domain.Candidato.ValueObjects.Assertions;

public static class CivilStatusAssertion
{
    public static Contract CreateCivilStatusContract(int code)
    {
        return new Contract()
            .IsBetween(code, 1, 4, "CivilStatus.IsBetween.Value", "O código de status civil tem que estar entre 1 e 4.");
    }
}
