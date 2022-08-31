namespace APIEnem.Domain.Models.Contracts.ValueObjects;

public interface IGeneralGrade : IObjectNotification
{
    public double Value { get; }
}
