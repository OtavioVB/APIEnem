﻿using APIEnem.Domain.Models.Interfaces;
using APIEnem.Domain.Models.Interfaces.Database.Participante;
using APIEnem.Domain.Models.Candidato;

namespace APIEnem.Infra.Data.Participante
{
    public class BancoParticipante : IDataParticipante
    {
        public Guid Identificador { get; set; } = Guid.NewGuid();
        public Guid IdentificadorConnection { get; set; }

        private readonly IDataConnection _conexaoBanco;
        private readonly IParticipanteDataActions _dataActions;

        public BancoParticipante(IDataConnection conexaoBanco, IParticipanteDataActions globalActions)
        {
            _dataActions = globalActions;
            _conexaoBanco = conexaoBanco;
            IdentificadorConnection = conexaoBanco.Identificador;
        }

        public ParticipanteData BuscarInformaçõesDoParticipante(NúmeroInscrição Número)
        {
            try
            {
                using (var comando = _conexaoBanco.Connection.CreateCommand())
                {
                    comando.CommandText = "SELECT * FROM TB_DADOS WHERE NU_INSCRICAO=@NúmeroDeInscrição";
                    comando.Parameters.AddWithValue("@NúmeroDeInscrição", Número.ToString());
                    return _dataActions.ConverterDataTableParaParticipanteData(_dataActions.ConverterComandoParaDataTable(comando));
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
