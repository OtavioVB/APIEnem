

namespace APIEnem.Models.Candidato
{
    public class Ano
    {
        public string Valor { get; set; }

        public Ano(string Ano)
        {
            if (Ano.Length != 4)
            {
                throw new Exception("O ano não condiz.");
            }

            foreach (char Letra in Ano)
            {
                if (char.IsDigit(Letra) is false)
                {
                    throw new Exception("O Ano não pode conter caracteres diferentes de dígitos.");
                }
            }

            this.Valor = Ano;
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}