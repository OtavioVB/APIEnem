using Flunt.Validations;

namespace APIEnem.Domain.Models.ValueObjects.Assertions;

public static class CorrectOrIncorrectAnswerAssertion
{
    public static Contract CreateAnswerContract(int valueAnswer)
    {
        return new Contract()
            .IsBetween(valueAnswer, 0, 45, "Answer.IncorretOrCorrect.Invalid.Value", "O número de acertos ou de erros tem que estar entre 0 e 45.");
    }
}
