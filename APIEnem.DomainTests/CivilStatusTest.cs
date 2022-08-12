using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIEnem.Domain.Models.Candidato;
using APIEnem.Domain.Models.Interfaces;


namespace APIEnem.DomainTests
{

    [TestClass]
    public class CivilStatusTest
    {
        public class FakeCivilStatusModel : IModelEstadoCivil
        {
            public string ConverterCódigoCivilParaTexto(int códigoEstadoCivil)
            {
                return "EstadoCivil";
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCivilStatusBiggerThanFour()
        {
            EstadoCivil estadoCivil = new EstadoCivil(5, new FakeCivilStatusModel());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCivilStatusLessThanZero()
        {
            EstadoCivil estadoCivil = new EstadoCivil(-1, new FakeCivilStatusModel());
        }
    }
}
