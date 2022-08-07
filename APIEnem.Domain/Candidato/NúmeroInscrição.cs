using APIEnem.Domain.Models.Exceptions;
using System;
using System.Text.RegularExpressions;

namespace APIEnem.Domain.Models.Candidato
{
    public class NúmeroInscrição
    {
        public string Número { get; set; }

        public NúmeroInscrição(string númeroDeInscrição)
        {
            var expressãoRegularNúmeroInscrição = new Regex(@"^[0-9]{12}$");
            
            if (expressãoRegularNúmeroInscrição.IsMatch(númeroDeInscrição))
            {
                Número = númeroDeInscrição;
            }
            else
            {
                throw new ModelException("API:MODELS:NUMERO_INSCRICAO:REGULAR_EXPRESSION:ERROR", "O número de inscrição não é válido", "Coloque um valor de número de inscrição válido");
            }
        }

        public override string ToString()
        {
            return Número;
        }
    }
}