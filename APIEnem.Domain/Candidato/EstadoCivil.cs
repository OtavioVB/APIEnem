using APIEnem.Domain.Models.Interfaces;

namespace APIEnem.Domain.Models.Candidato
{
    public class EstadoCivil
    {
        public int CódigoEstadoCivil { get; set; }
        public string EstadoCivilTexto { get; set; }


        public EstadoCivil(int estadoCivil, IModelEstadoCivil modelEstadoCivil)
        {
            if (estadoCivil > 4 is true || estadoCivil < 0 is true)
            {
                throw new Exception("Insira um Estado Civil válido");
            }

            EstadoCivilTexto = modelEstadoCivil.ConverterCódigoCivilParaTexto(estadoCivil);
            CódigoEstadoCivil = estadoCivil;
        }
    }
}
