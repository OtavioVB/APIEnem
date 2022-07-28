namespace APIEnem.Models.Candidato
{
    public class ParticipanteData
    {
        public NúmeroInscrição númeroInscrição { get; set; }
        public Ano AnoDoEnem { get; set; }
        public FaixaEtária FaixaEtária { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Linguagens LinguagensESuasTecnologias { get; set; }
        public Humanas CiênciasHumanasESuasTecnologias { get; set; }
        public Exatas MatemáticaESuasTecnologias { get; set; }
        public Naturais CiênciasDaNaturezaESuasTecnologias { get; set; }

        public ParticipanteData(NúmeroInscrição numInscrição, Ano anoEnem, FaixaEtária faixaEtária, Sexo sexo, EstadoCivil estadoCivil, Exatas matemáticaESuasTecnologias, Naturais ciênciasDaNaturezaESuasTecnologias, Humanas humanas, Linguagens linguagens)
        {
            this.númeroInscrição = numInscrição;
            this.AnoDoEnem = anoEnem;
            this.FaixaEtária = faixaEtária;
            this.Sexo = sexo;
            this.EstadoCivil = estadoCivil;
            this.MatemáticaESuasTecnologias = matemáticaESuasTecnologias;
            this.CiênciasDaNaturezaESuasTecnologias = ciênciasDaNaturezaESuasTecnologias;
            this.LinguagensESuasTecnologias = linguagens;
            this.CiênciasHumanasESuasTecnologias = humanas;
        }
    }
}
