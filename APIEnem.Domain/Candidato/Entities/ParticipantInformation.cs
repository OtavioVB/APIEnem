using APIEnem.Domain.Candidato.Contracts.ValueObjects;
using APIEnem.Domain.Candidato.Contracts.Entities;

namespace APIEnem.Domain.Candidato.Entities;

public class ParticipantInformation
{
    public IInscriptionNumber InscriptionNumber { get; private set; }
    public IAno Year { get; private set; }
    public IAgeGroup AgeGroup { get; private set; }
    public IGender Gender { get; private set; }
    public ICivilStatus CivilStatus { get; private set; }
    public IRedaction Redaction { get; private set; }

    public ParticipantInformation(IInscriptionNumber inscriptionNumber, IAno year, IAgeGroup ageGroup, IGender gender, ICivilStatus civilStatus, IRedaction redaction)
    {
        InscriptionNumber = inscriptionNumber;
        Year = year;
        AgeGroup = ageGroup;
        Gender = gender;
        CivilStatus = civilStatus;
        Redaction = redaction;
    }
}
