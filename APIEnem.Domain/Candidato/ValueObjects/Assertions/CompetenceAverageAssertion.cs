using Flunt.Validations;

namespace APIEnem.Domain.Candidato.ValueObjects.Assertions;

public static class CompetenceAverageAssertion
{
    public static Contract CreateCompetenceAverageContract(int value)
    {
        return new Contract()
            .IsBetween(value, 0, 200, "CompetenceAverage.Value", "O valor médio para as competência tem que estar entre 0 e 200.");
    }
}
