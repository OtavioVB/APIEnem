using APIEnem.Domain.Candidato.Contracts.ValueObjects;
using APIEnem.Domain.Candidato.Contracts.Entities;

namespace APIEnem.Domain.Candidato.Entities;

public class Redaction : IRedaction
{
    public IGeneralGrade GeneralGrade { get; private set; }
    public ICompetence FirstCompetence { get; private set; }
    public ICompetence SecondCompetence { get; private set; }
    public ICompetence ThirdCompetence { get; private set; }
    public ICompetence FourthCompetence { get; private set; }
    public ICompetence FifthCompetence { get; private set; }
    public ICompetenceAverage CompetenceAverage { get; private set; }

    public Redaction(IGeneralGrade generalGrade, ICompetence firstCompetence, 
        ICompetence secondCompetence, ICompetence thirdCompetence, ICompetence fourthCompetence, 
        ICompetence fifthCompetence, ICompetenceAverage competenceAverage)
    {
        GeneralGrade = generalGrade;
        FirstCompetence = firstCompetence;
        SecondCompetence = secondCompetence;
        ThirdCompetence = thirdCompetence;
        FourthCompetence = fourthCompetence;
        FifthCompetence = fifthCompetence;
        CompetenceAverage = competenceAverage;
    }
}
