using Microsoft.AspNetCore.Mvc;
using APIEnem.Domain.Models.Candidato;
using APIEnem.Domain.Models.Interfaces;
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
            return Ok("Hello World");
        }
    }
}
