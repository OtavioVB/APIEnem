using APIEnem.Models.Interfaces;

namespace APIEnem.Models.Candidato
{
    public class EstadoCivil
    {
        public int CódigoEstadoCivil { get; set; }
        public string EstadoCivilTexto { get; set; }


        public EstadoCivil(int EstadoCivil, IModelEstadoCivil modelEstadoCivil)
        {
            if (EstadoCivil is not < 5 && EstadoCivil is not >= 0)
            {
                throw new Exception("Insira um Estado Civil válido");
            }

            this.EstadoCivilTexto = modelEstadoCivil.CONVERTER_CÓDIGO_CIVIL_PARA_TEXTO(EstadoCivil);
            this.CódigoEstadoCivil = EstadoCivil;
        }
    }
}
