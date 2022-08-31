using APIEnem.Domain.Models.Contracts.Infrascructure.Connection;
using APIEnem.Domain.Repositories.Persistence.Global;
using APIEnem.Domain.Models.Contracts.Infrascructure.Persistence.Participant;
using APIEnem.Domain.Models.Contracts.Entities;
using APIEnem.Domain.Models.Contracts.ValueObjects;

namespace APIEnem.Domain.Repositories.Persistence.Participant;

public class RepositoryParticipant : IRepositoryParticipant
{
    private readonly IDataConnection _dataConnection;

    public RepositoryParticipant(IDataConnection dataConnection)
    {
        _dataConnection = dataConnection;
    }

    public IParticipantInformation? GetParticipantDataInformation(IInscriptionNumber inscriptionNumber)
    {
        using (var command = _dataConnection.GetConnection().CreateCommand())
        {
            command.CommandText = "SELECT * FROM TB_DADOS WHERE NU_INSCRICAO=@inscriptionNumber";
            command.Parameters.AddWithValue("@inscriptionNumber", inscriptionNumber.Value);
            return Functions.ConvertDataTableToParticipantInformation(Functions.ConvertNpgsqlCommandToDataTable(command));
        }
    }
}
