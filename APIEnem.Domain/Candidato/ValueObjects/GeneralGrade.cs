﻿using Flunt.Notifications;
using APIEnem.Domain.Candidato.ValueObjects.Assertions;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Domain.Candidato.ValueObjects;

public class GeneralGrade : Notifiable, IGeneralGrade
{
    public double Value { get; private set; }

    public GeneralGrade(double value)
    {
        Value = value;
        Assert(GeneralGradeAssertion.CreateGeneralGradeContract(Value));
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}
