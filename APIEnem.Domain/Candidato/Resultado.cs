using System.Text.RegularExpressions;

namespace APIEnem.Domain.Models.Candidato
{
    public abstract class Resultado
    {
        protected static int Calcular(string Gabarito, string Respostas, out int erros)
        {
            var regex = new Regex("^[A-E9]{50}$|^[A-E]{45}$");
            
            if (!regex.IsMatch(Respostas))
            {
                erros = 45;
                return 0;
            }
            
            var númeroDeAcertos = 0;
            var númeroDeErros = 0;
            var alternativa = Respostas.ToCharArray();
            var gabarito = Gabarito.ToCharArray();
            
            for (var i = 0; i < gabarito.Length; i++)
            {
                if (alternativa[i] == '9')
                {
                    continue;
                }

                if (alternativa[i] == gabarito[i])
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
