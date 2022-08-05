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
        public double Nota { get; set; }

        public Naturais(string gabarito, string respostas, double nota)
        {
            Gabarito = gabarito;
            Respostas = respostas;
            Acertos = Calcular(Gabarito, Respostas, out var erro);
            Erros = erro;
            Nota = nota;
        }
    }
}
