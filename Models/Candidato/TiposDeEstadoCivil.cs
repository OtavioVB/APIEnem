using APIEnem.Models.Interfaces;

namespace APIEnem.Models.Candidato
{
    public class TiposDeEstadoCivil : IModelEstadoCivil
    {
        private Dictionary<int, string> _tiposEstadoCivil = new();
        
        public TiposDeEstadoCivil()
        {
            _tiposEstadoCivil.Add(0, "Não informado");
            _tiposEstadoCivil.Add(1, "Solteiro(a)");
            _tiposEstadoCivil.Add(2, "Casado(a)/Mora com companheiro(a)");
            _tiposEstadoCivil.Add(3, "Divorciado(a)/Desquitado(a)/Separado(a)");
            _tiposEstadoCivil.Add(4, "Viúvo(a)");
        }

        public string ConverterCódigoCivilParaTexto(int códigoEstadoCivil)
        {
            if (_tiposEstadoCivil.TryGetValue(códigoEstadoCivil, out var retorno))
            {
                return retorno;
            }
            
            throw new Exception("Não foi possível encontrar o tipo de estado civil com esse código!");
        }
    }
}
