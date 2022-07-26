using Microsoft.AspNetCore.Mvc;
using APIEnem.Models.Candidato;
using APIEnem.Models.Interfaces;
using APIEnem.Models.Application;
using APIEnem.Models.Exceptions;
using MySql.Data.MySqlClient;

namespace APIEnem.Controllers
{
    [ApiController]
    [Route("api/v1/content/[controller]")]
    public class ParticipanteController : ControllerBase
    {
        private readonly IDataParticipante _dataParticipante;

        public ParticipanteController(IDataParticipante dataParticipante)
        {
            this._dataParticipante = dataParticipante;
        }


        [HttpGet("{NúmeroInscrição}")]
        public IActionResult Get(string NúmeroInscrição)
        {
            try
            {
                string Retorno = _dataParticipante.BUSCAR_INFORMACOES_DO_PARTICIPANTE(new NúmeroInscrição(NúmeroInscrição)).ToString();
                return Ok(Retorno);
            }
            catch (MySqlException)
            {
                return BadRequest(new Json(new ResultRequest.BADREQUEST400(_dataParticipante.Identificador, new Message("CONTROLLERS:PARTICIPANTES:GET:DATABASES", "Um erro inesperado ocorreu com a database!", "Contate o suporte sobre o erro."), _dataParticipante.IdentificadorConnection)).ToString());
            }
            catch (ModelException MEx)
            {
                return BadRequest(new Json(new ResultRequest.BADREQUEST400(_dataParticipante.Identificador, new Message(MEx.ErrorLocal, MEx.Message, MEx.Action), _dataParticipante.IdentificadorConnection)).ToString());
            }
            catch(RequestException REx)
            {
                return NotFound(new Json(new ResultRequest.NOTFOUND404(_dataParticipante.Identificador, new Message(REx.ErrorLocal, REx.Message, REx.Action), _dataParticipante.IdentificadorConnection)).ToString());
            }
        }
    }
}
