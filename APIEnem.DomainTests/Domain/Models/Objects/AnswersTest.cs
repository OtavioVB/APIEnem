using APIEnem.Domain.Models.Contracts.ValueObjects;
using APIEnem.Domain.Models.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APIEnem.Tests.Domain.Models.Objects;

[TestClass]
public class AnswersTest
{
    [TestMethod]
    [TestCategory("Answers Validations")]
    [DataRow("ABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDE")]
    [DataRow("ABCDEABCDEABCDEABCDEABCDEABCDECDEABCDEABCDEAB99999")]
    [DataRow("ABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDE")]
    public void VerifyValidValueForRegularExpression(string value)
    {
        IAnswers answers = new Answers(value);
        Assert.AreEqual(true, answers.IsValid);
    }

    [TestMethod]
    [TestCategory("Answers Validations")]
    [DataRow("ABCDEABCDEABCDEABCDEABCDEABCDECDEABCDEAB99999")]
    [DataRow("ABCDE")]
    [DataRow("99999")]
    public void VerifyNotValidValueForRegularExpression(string value)
    {
        IAnswers answers = new Answers(value);
        Assert.AreEqual(false, answers.IsValid);
    }
}
