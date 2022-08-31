using APIEnem.Domain.Models.Contracts.ValueObjects;

namespace APIEnem.Domain.Models.Contracts.Entities;

public interface IParticipantInformation : IObjectNotification
{
    public IInscriptionNumber InscriptionNumber { get; }
    public IYear Year { get; }
    public IAgeGroup AgeGroup { get; }
    public IGender Gender { get; }
    public ICivilStatus CivilStatus { get; }
    public IRedaction Redaction { get; }
    public IKnowledgeArea HumanScience { get; }
    public IKnowledgeArea NaturalScience { get; }
    public IKnowledgeArea ExactScience { get; }
    public IKnowledgeArea LinguisticScience { get; }
}
