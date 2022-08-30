using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Domain.Candidato.Contracts.Entities;

public interface IKnowledgeArea
{
    IFeedback Feedback { get; }
    IAnswers Answers { get; }
    ICorrectOrIncorrectAnswer TotalCorrectAnswers { get; }
    ICorrectOrIncorrectAnswer TotalIncorrectAnswers { get; }
    IGeneralGrade GradeValue { get; }
}
