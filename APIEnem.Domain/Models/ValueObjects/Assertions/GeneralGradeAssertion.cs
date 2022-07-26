﻿using Flunt.Validations;

namespace APIEnem.Domain.Models.ValueObjects.Assertions;

public static class GeneralGradeAssertion
{
    public static Contract CreateGeneralGradeContract(double value)
    {
        return new Contract()
            .IsBetween(value,0, 1000, "GeneralGrade.Value", "É necessário que a nota geral esteja entre 0 e 1000.");
    }
}
