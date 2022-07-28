using System.Text.RegularExpressions;

namespace APIEnem.Models.Candidato
{
    public abstract class Resultado
    {
        public int Calcular(string Gabarito, string Respostas, out int Erros)
        {

            Regex regex = new Regex("^[A-E9]{50}$|^[A-E]{45}$");
            
            if (regex.IsMatch(Respostas) == false)
            {
                Erros = 45;
                return 0;
            }
            else
            {
                int NúmeroDeAcertos = 0;
                int NúmeroDeErros = 0;
                char[] ALTERNATIVA = Respostas.ToCharArray();
                char[] GABARITO = Gabarito.ToCharArray();
                for (int i = 0; i < GABARITO.Length; i++)
                {
                    if (ALTERNATIVA[i] == '9')
                    {
                        continue;
                    }

                    if (ALTERNATIVA[i] == GABARITO[i])
                    {
                        NúmeroDeAcertos++;
                    }
                    else
                    {
                        NúmeroDeErros++;
                    }
                }
                Erros = NúmeroDeErros;
                return NúmeroDeAcertos;
            }
        }
    }
}
