using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Domain.Candidato.Contracts.Entities;

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
