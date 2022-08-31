using System.Data;
using Npgsql;
using APIEnem.Domain.Models.Contracts.Entities;
using APIEnem.Domain.Models.Contracts.ValueObjects;

namespace APIEnem.Domain.Repositories.Persistence.Global;

public static class Functions
{
    public static DataTable ConvertNpgsqlCommandToDataTable(NpgsqlCommand command)
    {
        using (command)
        {
            using (var dataTable = new DataTable())
            {
                using (var dataAdapter = new NpgsqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    public static IParticipantInformation? ConvertDataTableToParticipantInformation(DataTable dataTable)
    {
        using (dataTable)
        {
            foreach (DataRow dataRow in dataTable.Rows)
            {
                return null;
            }

            return null;
        }
    }
}
