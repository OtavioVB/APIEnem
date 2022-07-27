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
            bool EXPRESSÃO_É_CORRETA = EXPRESSÃO_REGULAR_NÚMERO_INSCRIÇÃO.IsMatch(NúmeroDeInscrição);

            this.Número = NúmeroDeInscrição;
        }

        public override string ToString()
        {
            return Número;
        }
    }
}