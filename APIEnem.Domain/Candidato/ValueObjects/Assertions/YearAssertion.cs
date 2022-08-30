using Flunt.Validations;
using Flunt.Notifications;

namespace APIEnem.Domain.Candidato.ValueObjects.Assertions;

public static class YearAssertion
{
    public static Contract CreateYearContract(string value)
    {
        return new Contract()
            .AreEquals(value.Length, 4, "Year.AreEqualsFour.Value", "O ano é inválido, é necessário que contenha apenas quatro caracteres!")
            .IsFalse(VerifyExistsOnlyDigitInString(value), "Year.OnlyDigitChar.Value", "O ano deve conter apenas dígitos!");
    }

    private static bool VerifyExistsOnlyDigitInString(string text)
    {
        char[] chars = text.ToCharArray();

        foreach (char character in chars)
        {
            if (char.IsDigit(character) is false)
            {
                return false;
            }
        }

        return true;
    }
}
