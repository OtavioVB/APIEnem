using Flunt.Validations;

namespace APIEnem.Domain.Models.ValueObjects.Assertions;

public static class GenderAssertion
{
    public static Contract CreateGenderContract(char alphaNumeric)
    {
        return new Contract()
            .IsFalse(VerifiyAlphaNumericDigitIsValid(alphaNumeric), "Gender.InvalidAlphaNumericNumber.Value", "O valor alphanumérico é inválido.");
    }

    private static bool VerifiyAlphaNumericDigitIsValid(char alphaNumeric)
    {
        if (char.ToUpper(alphaNumeric) != 'F' && char.ToUpper(alphaNumeric) != 'M') return false;
        else return true;
    }
}
