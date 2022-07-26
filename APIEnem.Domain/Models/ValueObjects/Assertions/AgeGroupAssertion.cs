﻿using Flunt.Validations;

namespace APIEnem.Domain.Models.ValueObjects.Assertions;

public static class AgeGroupAssertion
{
    public static Contract CreateAgeGroupContract(int code)
    {
        return new Contract()
            .IsBetween(code, 1, 20, "AgeGroup.IsNotBetween.Value", "A faixa etária do participante tem que ter um código entre 0 e 20.");
    }
}
