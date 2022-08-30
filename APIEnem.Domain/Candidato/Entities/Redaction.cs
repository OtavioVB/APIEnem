﻿using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Domain.Candidato.Entities;

public class Redaction
{
    public IGeneralGrade GeneralGrade { get; private set; }
    public ICompetence FirstCompetence { get; private set; }
    public ICompetence SecondCompetence { get; private set; }
    public ICompetence ThirdCompetence { get; private set; }
    public ICompetence FourthCompetence { get; private set; }
    public ICompetence FifthCompetence { get; private set; }
    public ICompetenceAverage CompetenceAverage { get; private set; }

    public Redaction()
    {

    }
}
