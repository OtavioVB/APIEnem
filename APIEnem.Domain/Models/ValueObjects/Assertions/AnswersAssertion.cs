using Flunt.Validations;

namespace APIEnem.Domain.Models.ValueObjects.Assertions;

public static class AnswersAssertion
{
    public static Contract CreateAnswersContract(string answersValue)
    {
        return new Contract()
            .Matches(answersValue, "^[A-E9]{50}$|^[A-E]{45}$", "Answers.RegularExpression.Invalid.Value", "É necessário que as respostas estejam em um formato válido");
    }
}
