using APIEnem.Domain.Models.Candidato;

namespace APIEnem.Domain.Models.Interfaces
{
    public interface IModelFaixaEtaria
    {
        public string RetornarTipoDaFaixaEtária(FaixaEtária faixaEtária);
    }
}
