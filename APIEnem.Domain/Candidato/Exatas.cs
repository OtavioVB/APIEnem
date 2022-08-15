using APIEnem.Domain.Models.Interfaces;
using System.Text.RegularExpressions;

namespace APIEnem.Domain.Models.Candidato
{
    public class Exatas : IAreaDoConhecimento
    {
        public string Gabarito { get; set; }
        public string Respostas { get; set; }
        public int Acertos { get; set; }
        public int Erros { get; set; }
        public int Questões { get; set; } = 45;
        public double Nota { get; set; }

        public Exatas(string gabarito, string respostas, double nota)
        {
            Gabarito = gabarito;
            Respostas = respostas;
            Acertos = Calcular(Gabarito, Respostas, out var erro);
            Erros = erro;
            Nota = nota;
        }

        public int Calcular(string gabarito, string respostas, out int erros)
        {
            var regex = new Regex("^[A-E]{45}$");

            if (!regex.IsMatch(respostas))
            {
                erros = 45;
                return 0;
            }

            var númeroDeAcertos = 0;
            var númeroDeErros = 0;
            var alternativa = respostas.ToCharArray();
            var resultadogabarito = gabarito.ToCharArray();

            for (var i = 0; i < resultadogabarito.Length; i++)
            {
                if (alternativa[i] == '9')
                {
                    continue;
                }

                if (alternativa[i] == resultadogabarito[i])
                {
                    númeroDeAcertos++;
                }
                else
                {
                    númeroDeErros++;
                }
            }

            erros = númeroDeErros;

            return númeroDeAcertos;
        }
    }
}
