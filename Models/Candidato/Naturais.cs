using APIEnem.Models.Interfaces;

namespace APIEnem.Models.Candidato
{
    public class Naturais : Resultado, IAreaDoConhecimento
    {
        public string Gabarito { get; set; }
        public string Respostas { get; set; }
        public int Acertos { get; set; }
        public int Erros { get; set; }
        public int Questões { get; set; } = 45;

        public Naturais(string gabarito, string respostas)
        {
            int Erro = 0;
            this.Gabarito = gabarito;
            this.Respostas = respostas;
            this.Acertos = Calcular(Gabarito, Respostas, out Erro);
            this.Erros = Erro;
        }
    }
}
