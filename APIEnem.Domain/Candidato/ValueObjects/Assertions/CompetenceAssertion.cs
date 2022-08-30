using Flunt.Validations;

namespace APIEnem.Domain.Candidato.ValueObjects.Assertions;

public static class CompetenceAssertion
{
    public static Contract CreateCompetenceContract(int value)
    {
        return new Contract()
            .IsBetween(value, 0, 200, "Competence.Value", "É necessário haver nota de competência válida, estando entre 0 e 200.")
            .IsFalse(VerifiyCompetenceGradeIsValid(value), "Competence.IsValid.DivisionPerTwenty.Value", "A nota de sua competência tem que ser divisível por 20.");
    }

    private static bool VerifiyCompetenceGradeIsValid(int value)
    {
        if (value % 20 != 0) return false;
        else return true;
    }
}
