using APIEnem.Domain.Models.Contracts.ValueObjects;

namespace APIEnem.Domain.Models.Contracts.Entities;

public interface IRedaction
{
    public IGeneralGrade GeneralGrade { get; }
    public ICompetence FirstCompetence { get; }
    public ICompetence SecondCompetence { get; }
    public ICompetence ThirdCompetence { get; }
    public ICompetence FourthCompetence { get; }
    public ICompetence FifthCompetence { get; }
    public ICompetenceAverage CompetenceAverage { get; }
}
