using APIEnem.Infra.Data.Contracts.Connection;
using APIEnem.Infra.Data.Persistence.Global;
using APIEnem.Domain.Candidato.Entities;
using APIEnem.Domain.Candidato.Contracts.ValueObjects;

namespace APIEnem.Infra.Data.Persistence.Participant;

public class RepositoryParticipant
{
    private readonly IDataConnection _dataConnection;

    public RepositoryParticipant(IDataConnection dataConnection)
    {
        _dataConnection = dataConnection;
    }

    public ParticipantInformation? GetParticipantDataInformation(IInscriptionNumber inscriptionNumber)
    {
        using (var command = _dataConnection.GetConnection().CreateCommand())
        {
            command.CommandText = "SELECT * FROM TB_DADOS WHERE NU_INSCRICAO=@inscriptionNumber";
            command.Parameters.AddWithValue("@inscriptionNumber", inscriptionNumber);
            return Functions.ConvertDataTableToParticipantInformation(Functions.ConvertNpgsqlCommandToDataTable(command));
        }
    }
}
