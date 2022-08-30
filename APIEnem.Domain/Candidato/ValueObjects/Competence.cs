namespace APIEnem.Domain.Candidato.ValueObjects;

public class Competence
{
    public int Value { get; private set; }

    public Competence(int value)
    {
        Value = value;

    }

    public override string ToString() 
    { 
        return Value.ToString(); 
    }
}
