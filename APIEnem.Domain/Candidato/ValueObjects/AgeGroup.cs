using Flunt.Notifications;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Domain.Candidato.ValueObjects;

public class AgeGroup : Notifiable, IAgeGroup
{
    public int Code { get; private set; }
    public string Text { get; private set; } 

    public AgeGroup(int code)
    {
        Code = code;
        Text = ConvertCodeToAgeGroupText(code);
        Assert(AgeGroupAssertion.CreateAgeGroupContract(Code));
    }

    private string ConvertCodeToAgeGroupText(int code)
    {
        return code switch
        {
            1 => "Menor de 17 anos",
            2 => "17 anos",
            3 => "18 anos",
            4 => "19 anos",
            5 => "20 anos",
            6 => "21 anos",
            7 => "22 anos",
            8 => "23 anos",
            9 => "24 anos",
            10 => "25 anos",
            11 => "Entre 26 e 30 anos",
            12 => "Entre 31 e 35 anos",
            13 => "Entre 36 e 40 anos",
            14 => "Entre 41 e 45 anos",
            15 => "Entre 46 e 50 anos",
            16 => "Entre 51 e 55 anos",
            17 => "Entre 56 e 60 anos",
            18 => "Entre 61 e 65 anos",
            19 => "Entre 66 e 70 anos",
            20 => "Maior de 70 anos",
            _ => "Indeterminado(a)",
        };
    }

    public override string ToString()
    {
        return Text;
    }
}
