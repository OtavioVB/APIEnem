using APIEnem.Domain.Candidato.ValueObjects;

namespace APIEnem.Domain.Candidato.Entities;

public class Redaction
{
    public int GeneralGrade { get; private set; }
    public Competence FirstCompetence { get; private set; }
    public Competence SecondCompetence { get; private set; }
    public Competence ThirdCompetence { get; private set; }
    public Competence FourthCompetence { get; private set; }
    public Competence FifthCompetence { get; private set; }
    public int CompetenceAverage { get; private set; }

    public Redaction()
    {

    }
}
