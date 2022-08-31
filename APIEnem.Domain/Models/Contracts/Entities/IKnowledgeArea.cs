using APIEnem.Domain.Models.Contracts.ValueObjects;

namespace APIEnem.Domain.Models.Contracts.Entities;

public interface IKnowledgeArea
{
    IFeedback Feedback { get; }
    IAnswers Answers { get; }
    ICorrectOrIncorrectAnswer TotalCorrectAnswers { get; }
    ICorrectOrIncorrectAnswer TotalIncorrectAnswers { get; }
    IGeneralGrade GradeValue { get; }
}
