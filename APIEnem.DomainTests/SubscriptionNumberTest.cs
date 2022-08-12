using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIEnem.Domain.Models.Exceptions;
using APIEnem.Domain.Models.Candidato;

namespace APIEnem.DomainTests
{
    [TestClass]
    public class SubscriptionNumberTest
    {
        [TestMethod]
        [ExpectedException(typeof(ModelException))]
        public void TestInvalidSubscriptionNumberWithBiggerThanCharWithLetter()
        {
            NúmeroInscrição númeroInscrição = new NúmeroInscrição("123456789123a");
        }

        [TestMethod]
        [ExpectedException(typeof(ModelException))]
        public void TestInvalidSubscriptionNumberWithBiggerThanCharWithDigit()
        {
            NúmeroInscrição númeroInscrição = new NúmeroInscrição("0000000000000");
        }

        [TestMethod]
        [ExpectedException(typeof(ModelException))]
        public void TestInvalidSubscriptionNumberWithBiggerThanCharWithFalseNumber()
        {
            NúmeroInscrição númeroInscrição = new NúmeroInscrição("12345678912²");
        }

        [TestMethod]
        [ExpectedException(typeof(ModelException))]
        public void TestInvalidSubscriptionNumberWithLessThanNumber()
        {
            NúmeroInscrição númeroInscrição = new NúmeroInscrição("12345678912");
        }
    }
}
