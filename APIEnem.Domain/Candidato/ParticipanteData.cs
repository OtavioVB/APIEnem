namespace APIEnem.Domain.Models.Candidato
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
        public Redação ProvaDissertativa { get; set; }

        public ParticipanteData(
            NúmeroInscrição numInscrição, 
            Ano anoEnem,
            FaixaEtária faixaEtária,
            Sexo sexo,
            EstadoCivil estadoCivil,
            Exatas matemáticaESuasTecnologias,
            Naturais ciênciasDaNaturezaESuasTecnologias,
            Humanas humanas,
            Linguagens linguagens,
            Redação provaDissertativa)
        {
            númeroInscrição = numInscrição;
            AnoDoEnem = anoEnem;
            FaixaEtária = faixaEtária;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            MatemáticaESuasTecnologias = matemáticaESuasTecnologias;
            CiênciasDaNaturezaESuasTecnologias = ciênciasDaNaturezaESuasTecnologias;
            LinguagensESuasTecnologias = linguagens;
            CiênciasHumanasESuasTecnologias = humanas;
            ProvaDissertativa = provaDissertativa;
        }
    }
}
