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

        public Redação(int NotaGeral, int Competencia1, int Competencia2, int Competencia3, int Competencia4, int Competencia5)
        {
            this.NotaGeral = NotaGeral;
            this.Competencia1 = Competencia1;
            this.Competencia2 = Competencia2;
            this.Competencia3 = Competencia3;
            this.Competencia4 = Competencia4;
            this.Competencia5 = Competencia5;
            this.MediaCompetencia = CalcularMedia(NotaGeral);
        }

        private int CalcularMedia(int NotaGeral)
        {
            return NotaGeral / 5;
        }
    }
}
