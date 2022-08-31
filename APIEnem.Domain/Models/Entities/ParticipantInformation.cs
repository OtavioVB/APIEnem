using APIEnem.Domain.Models.Contracts.ValueObjects;
using APIEnem.Domain.Models.Contracts.Entities;
using Flunt.Notifications;

namespace APIEnem.Domain.Models.Entities;

public class ParticipantInformation : Notifiable, IParticipantInformation
{
    public IInscriptionNumber InscriptionNumber { get; private set; }
    public IYear Year { get; private set; }
    public IAgeGroup AgeGroup { get; private set; }
    public IGender Gender { get; private set; }
    public ICivilStatus CivilStatus { get; private set; }
    public IRedaction Redaction { get; private set; }
    public IKnowledgeArea HumanScience { get; private set; }
    public IKnowledgeArea NaturalScience { get; private set; }
    public IKnowledgeArea ExactScience { get; private set; }
    public IKnowledgeArea LinguisticScience { get; private set; }

    public ParticipantInformation(IInscriptionNumber inscriptionNumber, IYear year, IAgeGroup ageGroup, IGender gender, ICivilStatus civilStatus, 
        IRedaction redaction, IKnowledgeArea humanScience, IKnowledgeArea naturalScience, IKnowledgeArea exactScience, IKnowledgeArea linguisticScience)
    {
        InscriptionNumber = inscriptionNumber;
        Year = year;
        AgeGroup = ageGroup;
        Gender = gender;
        CivilStatus = civilStatus;
        Redaction = redaction;
        HumanScience = humanScience;
        NaturalScience = naturalScience;
        ExactScience = exactScience;
        LinguisticScience = linguisticScience;
    }
}
