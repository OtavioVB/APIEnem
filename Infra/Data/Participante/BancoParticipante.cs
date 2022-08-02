using MySql.Data.MySqlClient;
using System.Data;
using APIEnem.Models.Interfaces;
using APIEnem.Models.Interfaces.Database.Participante;
using APIEnem.Models.Candidato;
using APIEnem.Models.Exceptions;

namespace APIEnem.Infra.Data.Participante
{
    public class BancoParticipante : IDataParticipante
    {
        public Guid Identificador { get; set; } = Guid.NewGuid();
        public Guid IdentificadorConnection { get; set; }

        private readonly IDataConnection _conexaoBanco;
        private readonly IParticipanteDataActions _dataActions;

        public BancoParticipante(IDataConnection conexaoBanco, IParticipanteDataActions globalActions )
        {
            this._dataActions = globalActions;
            this._conexaoBanco = conexaoBanco;
            this.IdentificadorConnection = conexaoBanco.Identificador;
        }

        public ParticipanteData BUSCAR_INFORMACOES_DO_PARTICIPANTE(NúmeroInscrição Número)
        {
            try
            {
                using (MySqlCommand Comando = _conexaoBanco.Connection.CreateCommand())
                {
                    Comando.CommandText = "SELECT * FROM TB_DADOS WHERE NU_INSCRICAO = @NúmeroDeInscrição LIMIT 1;";
                    Comando.Parameters.AddWithValue("@NúmeroDeInscrição", Número.ToString());
                    return _dataActions.ConverterDataTableParaParticipanteData(_dataActions.ConverterComandoParaDataTable(Comando));
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
