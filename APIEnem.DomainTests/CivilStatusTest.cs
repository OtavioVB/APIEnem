using APIEnem.Domain.Models.Candidato;
using APIEnem.Domain.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace APIEnem.DomainTests
{
    [TestClass]
    public class CivilStatusTest
    {
        public class FakeModelCivilStatus : IModelEstadoCivil
        {
            public string ConverterCódigoCivilParaTexto(int códigoEstadoCivil)
            {
                return "EstadoCivil";
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CivilStatusNumberBiggerThanFour()
        {
            EstadoCivil estadoCivil = new EstadoCivil(5, new FakeModelCivilStatus());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CivilStatusNumberLessThanZero()
        {
            EstadoCivil estadoCivil = new EstadoCivil(-1, new FakeModelCivilStatus());
        }

        [TestMethod]
        public void CivilStatusTextTest()
        {
            EstadoCivil estadoCivil = new EstadoCivil(3, new FakeModelCivilStatus());
            Assert.AreEqual(true, estadoCivil.EstadoCivilTexto == "EstadoCivil");
        }
    }
}
