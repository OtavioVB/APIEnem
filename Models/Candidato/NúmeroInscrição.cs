using APIEnem.Models.Exceptions;

namespace APIEnem.Models.Candidato
{
    public class NúmeroInscrição
    {
        private string Número { get; set; }

        public NúmeroInscrição(string NúmeroDeInscrição)
        {
            if (NúmeroDeInscrição.Length != 12)
            {
                throw new ModelException("INFRA:MODELS:CANDIDATO:NUMERO_INSCRICAO:NOT_DIGIT", "O número de inscrição não possui seu tamanho correto", "Insira apenas Número de Inscrições com 12 dígitos");
            }

            foreach (char Letra in NúmeroDeInscrição)
            {
                if (char.IsDigit(Letra) is false)
                {
                    throw new ModelException("INFRA:MODELS:CANDIDATO:NUMERO_INSCRICAO:NOT_DIGIT", "O número de inscrição não possui apenas dígitos", "Insira apenas Número de Inscrições com dígitos");
                }
            }

            this.Número = NúmeroDeInscrição;
        }

        public override string ToString()
        {
            return Número;
        }
    }
}