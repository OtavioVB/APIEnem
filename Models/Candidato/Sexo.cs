namespace APIEnem.Models.Candidato
{
    public class Sexo
    {
        public char RepresentaçãoSexo { get; set; }
        public string SexoReal { get; set; }

        public Sexo(char alfanumérico)
        {
            if (char.ToUpper(alfanumérico) != 'F' && char.ToUpper(alfanumérico) != 'M')
            {
                throw new Exception("O alfanumérico inserido não é valido.");
            }

            SexoReal = char.ToUpper(alfanumérico) == 'F' ? "Feminino" : "Masculino";

            RepresentaçãoSexo = alfanumérico;
        }

        public char CódigoSexo()
        {
            return RepresentaçãoSexo;
        }

        public string GetSexo()
        {
            return SexoReal;
        }
    }
}
