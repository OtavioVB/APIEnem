using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIEnem.Domain.Models.Contracts.ValueObjects;
using APIEnem.Domain.Models.ValueObjects;

namespace APIEnem.Tests.Domain.Models.Objects;

[TestClass]
public class AgeGroupTests
{
    [TestMethod]
    [TestCategory("Age Group Validations")]
    [DataRow(21), DataRow(-1), DataRow(22), DataRow(0)]
    public void VerifyCodeThatIsNotBetweenOneAndTwenty(int value)
    {
        IAgeGroup ageGroup = new AgeGroup(value);
        Assert.IsFalse(ageGroup.IsValid);
    }

    [TestMethod]
    [TestCategory("Age Group Validations")]
    [DataRow(20), DataRow(1), DataRow(19), DataRow(2)]
    public void VerifiyCodeThatIsBetweenOneAndTwenty(int value)
    {
        IAgeGroup ageGroup = new AgeGroup(value);
        Assert.IsTrue(ageGroup.IsValid);
    }

    [TestMethod]
    [TestCategory("Age Group Validations")]
    [DataRow(1000), DataRow(21), DataRow(0)]
    public void VerifyUnexpectedAgeGroupNameForInvalidNumber(int value)
    {
        IAgeGroup ageGroup = new AgeGroup(value);
        Assert.AreEqual("Indeterminado(a)", ageGroup.Text);
    }
}
