namespace APIEnem.Models.Candidato
{
    public class Ano
    {
        public string Valor { get; set; }

        public Ano(string ano)
        {
            if (ano.Length != 4)
            {
                throw new Exception("O ano não condiz.");
            }

            foreach (char letra in ano)
            {
                if (!char.IsDigit(letra))
                {
                    throw new Exception("O Ano não pode conter caracteres diferentes de dígitos.");
                }
            }

            Valor = ano;
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}