namespace APIEnem.Domain.Models.Candidato
{
    public class FaixaEtária
    {
        public string Valor { get; set; }
        
        public FaixaEtária(string códigoDeFaixa)
        {
            if (códigoDeFaixa.Length != 1 && códigoDeFaixa.Length != 2)
            {
                throw new Exception("Código de faixa não condiz com o esperado");
            }

            if (códigoDeFaixa.Any(letra => char.IsDigit(letra) is false))
            {
                throw new Exception("O Código de faixa etária só pode conter dígitos");
            }

            Valor = códigoDeFaixa;
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}
