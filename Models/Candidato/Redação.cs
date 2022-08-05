using APIEnem.Models.Interfaces;

namespace APIEnem.Models.Candidato
{
    public class Redação : IModelRedação
    {
        public int NotaGeral { get; set; }
        public int Competencia1 { get; set; }
        public int Competencia2 { get; set; }
        public int Competencia3 { get; set; }
        public int Competencia4 { get; set; }
        public int Competencia5 { get; set; }
        public int MediaCompetencia { get; set; }

        public Redação(int notaGeral, int competencia1, int competencia2, int competencia3, int competencia4, int competencia5)
        {
            NotaGeral = notaGeral;
            Competencia1 = competencia1;
            Competencia2 = competencia2;
            Competencia3 = competencia3;
            Competencia4 = competencia4;
            Competencia5 = competencia5;
            MediaCompetencia = CalcularMedia(notaGeral);
        }

        private static int CalcularMedia(int notaGeral)
        {
            return notaGeral / 5;
        }
    }
}
