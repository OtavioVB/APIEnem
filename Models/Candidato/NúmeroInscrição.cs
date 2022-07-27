using APIEnem.Models.Exceptions;
using System;
using System.Text.RegularExpressions;

namespace APIEnem.Models.Candidato
{
    public class NúmeroInscrição
    {
        private string Número { get; set; }

        public NúmeroInscrição(string NúmeroDeInscrição)
        {
            Regex EXPRESSÃO_REGULAR_NÚMERO_INSCRIÇÃO = new Regex(@"^[0-9]{12}$");
            if (EXPRESSÃO_REGULAR_NÚMERO_INSCRIÇÃO.IsMatch(NúmeroDeInscrição) == true)
            {
                this.Número = NúmeroDeInscrição;
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