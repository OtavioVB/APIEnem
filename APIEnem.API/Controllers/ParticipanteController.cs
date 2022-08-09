using Microsoft.AspNetCore.Mvc;
using APIEnem.Domain.Models.Candidato;
using APIEnem.Domain.Models.Interfaces;
using APIEnem.Domain.Models.Application;
using APIEnem.Domain.Models.Exceptions;
using Npgsql;

namespace APIEnem.API.Controllers
{
    [ApiController]
    [Route("api/v1/content/[controller]")]
    public class ParticipanteController : ControllerBase
    {
        private readonly IDataParticipante _dataParticipante;

        public ParticipanteController(IDataParticipante dataParticipante)
        {
            _dataParticipante = dataParticipante;
        }


        [HttpGet("{NúmeroInscrição}")]
        public IActionResult Get(string NúmeroInscrição)
        {
            try
            {
                return Ok(new Json(new ResultRequest.Ok200(_dataParticipante.Identificador,new Message("CONTROLLERS:PARTICIPANTES:GET:DATABASES:GOOD_RESULT","Chamada realizada com sucesso!", "Get recebido."), _dataParticipante.IdentificadorConnection, _dataParticipante.BuscarInformaçõesDoParticipante(new NúmeroInscrição(NúmeroInscrição)))).ToString());
            }
            catch (NpgsqlException)
            {
                return BadRequest(new Json(new ResultRequest.BadRequest400(_dataParticipante.Identificador, new Message("CONTROLLERS:PARTICIPANTES:GET:DATABASES", "Um erro inesperado ocorreu com a database!", "Contate o suporte sobre o erro."), _dataParticipante.IdentificadorConnection)).ToString());
            }
            catch (ModelException MEx)
            {
                return BadRequest(new Json(new ResultRequest.BadRequest400(_dataParticipante.Identificador, new Message(MEx.ErrorLocal, MEx.Message, MEx.Action), _dataParticipante.IdentificadorConnection)).ToString());
            }
            catch(RequestException REx)
            {
                return NotFound(new Json(new ResultRequest.BadRequest400(_dataParticipante.Identificador, new Message(REx.ErrorLocal, REx.Message, REx.Action), _dataParticipante.IdentificadorConnection)).ToString());
            }
        }
    }
}
