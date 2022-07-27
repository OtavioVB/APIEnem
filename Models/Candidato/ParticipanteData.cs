namespace APIEnem.Models.Candidato
{
    public class ParticipanteData
    {
        public NúmeroInscrição númeroInscrição { get; set; }
        public Ano AnoDoEnem { get; set; }
        public FaixaEtária FaixaEtária { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }

        public ParticipanteData(NúmeroInscrição numInscrição, Ano anoEnem, FaixaEtária faixaEtária, Sexo sexo, EstadoCivil estadoCivil)
        {
            this.númeroInscrição = numInscrição;
            this.AnoDoEnem = anoEnem;
            this.FaixaEtária = faixaEtária;
            this.Sexo = sexo;
            this.EstadoCivil = estadoCivil;
        }
    }
}
