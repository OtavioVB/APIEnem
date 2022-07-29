using APIEnem.Models.Interfaces;

namespace APIEnem.Models.Candidato
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
            int Erro = 0;
            this.Gabarito = gabarito;
            this.Respostas = respostas;
            this.Acertos = Calcular(Gabarito, Respostas, out Erro);
            this.Erros = Erro;
            this.Nota = nota;
        }
    }
}
