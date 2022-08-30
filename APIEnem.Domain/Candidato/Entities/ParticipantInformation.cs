using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Domain.Candidato.Entities;

public class ParticipantInformation
{
    public IInscriptionNumber InscriptionNumber { get; private set; }
    public IAno Year { get; private set; }
    public IAgeGroup AgeGroup { get; private set; }
    public IGender Gender { get; private set; }
    public ICivilStatus CivilStatus { get; private set; }
    public Redaction Redaction { get; private set; }

    public ParticipantInformation(IInscriptionNumber inscriptionNumber, IAno year, IAgeGroup ageGroup, IGender gender, ICivilStatus civilStatus, Redaction redaction)
    {
        InscriptionNumber = inscriptionNumber;
        Year = year;
        AgeGroup = ageGroup;
        Gender = gender;
        CivilStatus = civilStatus;
        Redaction = redaction;
    }
}
