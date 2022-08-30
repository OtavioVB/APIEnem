using Flunt.Notifications;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;

namespace APIEnem.Domain.Candidato.ValueObjects;

public class Gender : Notifiable, IGender
{
    public string Text { get; private set; }
    public char AlphaNumeric { get; private set; }

    public Gender(char alphaNumeric)
    {
        AlphaNumeric = alphaNumeric;
        Text = ConvertAlphaNumericValueToString(AlphaNumeric);
        Assert(GenderAssertion.CreateGenderContract(AlphaNumeric));
    }

    private string ConvertAlphaNumericValueToString(char alphaNumeric)
    {
        if (char.ToUpper(alphaNumeric) == 'F')
        {
            return "Feminino";
        }
        else if (char.ToUpper(alphaNumeric) == 'M')
        {
            return "Masculino";
        }
        else
        {
            AddNotification("ConvertAlphaNumericValueToString.Value", "É necessário inserir um alfanúmerico válido para sexo. (M ou F)");
            return "Indeterminado";
        }
    }
}
