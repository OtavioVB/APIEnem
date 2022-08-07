namespace APIEnem.Domain.Models.Interfaces
{
    public interface IModelRedação
    {
        public int NotaGeral { get; set; }
        public int Competencia1 { get; set; }
        public int Competencia2 { get; set; }
        public int Competencia3 { get; set; }
        public int Competencia4 { get; set; }
        public int Competencia5 { get; set; }
        public int MediaCompetencia { get; set; }
    }
}
