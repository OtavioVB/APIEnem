using Flunt.Validations;

namespace APIEnem.Domain.Candidato.ValueObjects.Assertions;

public static class FeedbackAssertion
{
    public static Contract CreateFeedbackContract(string feedback)
    {
        return new Contract()
            .Matches(feedback, "^[A-E]{50}$|^[A-E]{45}$", "Feedback.Matches.Regex.Value", "É necessário que a cadeia de caracteres do gabarito seja válido.");
    }
}
