namespace APIEnem.Domain.Models.Interfaces
{
    public interface IAreaDoConhecimento
    {
        public string Gabarito { get; set; }
        public string Respostas { get; set; }
        public int Acertos { get; set; }
        public int Erros { get; set; }
        public int Questões { get; set; }
        public double Nota { get; set; }

        public int Calcular(string Gabarito, string Respostas, out int Erros);
    }
}
