using APIEnem.Domain.Candidato.Contracts.Entities;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;
using APIEnem.Domain.Candidato.ValueObjects;
using Flunt.Notifications;

namespace APIEnem.Domain.Candidato.Entities.KnowledgeAreas;

public class ExactScience : Notifiable, IKnowledgeArea
{
    public IFeedback Feedback { get; private set; }
    public IAnswers Answers { get; private set; }
    public ICorrectOrIncorrectAnswer TotalCorrectAnswers { get; private set; }
    public ICorrectOrIncorrectAnswer TotalIncorrectAnswers { get; private set; }
    public IGeneralGrade GradeValue { get; private set; }

    public ExactScience(IFeedback feedback, IAnswers answers, IGeneralGrade gradeValue)
    {
        Feedback = feedback;
        Answers = answers;
        GradeValue = gradeValue;
        TotalCorrectAnswers = CalculateTotalCorrectAnswers(Feedback, Answers);
        TotalIncorrectAnswers = CalculateTotalIncorrectAnswers(TotalCorrectAnswers);
    }

    private ICorrectOrIncorrectAnswer CalculateTotalCorrectAnswers(IFeedback feedback, IAnswers answers)
    {
        char[] correctFeedback = feedback.ValuePerQuestion;
        char[] participantAnswers = answers.ValuePerQuestion;
        var correctAnswers = 0;

        for (int i = 0; i < participantAnswers.Length; i++)
        {
            if (participantAnswers[i] == correctFeedback[i]) correctAnswers++;
        }

        return new CorrectAnswers(correctAnswers);
    }

    private ICorrectOrIncorrectAnswer CalculateTotalIncorrectAnswers(ICorrectOrIncorrectAnswer correctAnswersNumber)
    {
        return new IncorrectAnswers(45 - correctAnswersNumber.Value);
    }
}