using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIEnem.Domain.Models.Candidato;

namespace APIEnem.DomainTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestYearClassNumberBiggerThanFour()
        {
            Ano ano = new Ano("32422");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestYearClassNumberLessThanFour()
        {
            Ano ano = new Ano("324");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestYearClassStringIsPontuaction()
        {
            Ano ano = new Ano("324*");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestYearClassStringIsFalseNumber()
        {
            Ano ano = new Ano("324²");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestYearClassNumberIsChar()
        {
            Ano ano = new Ano("321a");
        }
    }
}