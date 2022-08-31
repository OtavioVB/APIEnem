using APIEnem.Domain.Models.ValueObjects.Assertions;
using APIEnem.Domain.Models.Contracts.ValueObjects;
using Flunt.Notifications;

namespace APIEnem.Domain.Models.ValueObjects;

public class CivilStatus : Notifiable, ICivilStatus
{
    public int Code { get; private set; }
    public string Text { get; private set; }

    public CivilStatus(int code)
    {
        Code = code;
        Text = ConvertCodeToText(code);
        CivilStatusAssertion.CreateCivilStatusContract(code);
    }

    private string ConvertCodeToText(int code)
    {
        if (this.IsValid == true)
        {
            switch (code)
            {
                case 1:
                    return "Solteiro(a)";
                case 2:
                    return "Casado(a)/Mora com companheiro(a)";
                case 3:
                    return "Divorciado(a)/Desquitado(a)/Separado(a)";
                case 4:
                    return "Viúvo(a)";
                default:
                    return "Não informado(a)";
            }
        }
        else
        {
            AddNotification("ConvertCodeToText.Invalid", "É necessário imprimir um código civil válido para converter para texto.");
            return "Não informado(a)";
        }
    }
}
