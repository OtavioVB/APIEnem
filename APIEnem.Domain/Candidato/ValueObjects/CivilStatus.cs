using APIEnem.Domain.Candidato.ValueObjects.Assertions;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;
using Flunt.Notifications;

namespace APIEnem.Domain.Candidato.ValueObjects;

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
            return code switch
            {
                1 => "Solteiro(a)",
                2 => "Casado(a)/Mora com companheiro(a)",
                3 => "Divorciado(a)/Desquitado(a)/Separado(a)",
                4 => "Viúvo(a)",
                _ => "Não informado(a)",
            };
        }
        else
        {
            AddNotification("ConvertCodeToText.Invalid", "É necessário imprimir um código civil válido para converter para texto.");
            return "Não informado(a)";
        }
    }
}
