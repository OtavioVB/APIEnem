using Microsoft.AspNetCore.Mvc;
using APIEnem.Domain.Models.Contracts.Handlers;
using APIEnem.Domain.Request.Participant;
using APIEnem.Domain.Models.ValueObjects;

namespace APIEnem.API.Controllers
{
    [ApiController]
    [Route("api/v1/content/[controller]")]
    public class ParticipantController : ControllerBase
    {
        private readonly IParticipantHandler _participantHandler;
        
        public ParticipantController([FromServices] IParticipantHandler participantHandler)
        {
            _participantHandler = participantHandler;
        }


        [HttpGet("{inscriptionNumber}")]
        public IActionResult Get(string inscriptionNumber)
        {
            var result = _participantHandler.Handle(new RequestWithInscritiptionNumber(new InscriptionNumber(inscriptionNumber)));
            return Ok(result);
        }
    }
}
