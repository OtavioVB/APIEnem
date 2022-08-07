using APIEnem.Domain.Models.Interfaces;

namespace APIEnem.Domain.Models.Candidato
{
    public class Humanas : Resultado, IAreaDoConhecimento
    {
        public string Gabarito { get; set; }
        public string Respostas { get; set; }
        public int Acertos { get; set; }
        public int Erros { get; set; }
        public int Questões { get; set; } = 45;
        public double Nota { get; set; }

        public Humanas(string gabarito, string respostas, double nota)
        {
            Gabarito = gabarito;
            Respostas = respostas;
            Acertos = Calcular(Gabarito, Respostas, out var erro);
            Erros = erro;
            Nota = nota;
        }
    }
}
