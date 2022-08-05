using APIEnem.Models.Interfaces;

namespace APIEnem.Models.Candidato
{
    public class EstadoCivil
    {
        public int CódigoEstadoCivil { get; set; }
        public string EstadoCivilTexto { get; set; }


        public EstadoCivil(int estadoCivil, IModelEstadoCivil modelEstadoCivil)
        {
            if (estadoCivil is not < 5 && estadoCivil is not >= 0)
            {
                throw new Exception("Insira um Estado Civil válido");
            }

            EstadoCivilTexto = modelEstadoCivil.ConverterCódigoCivilParaTexto(estadoCivil);
            CódigoEstadoCivil = estadoCivil;
        }
    }
}
