using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace APIEnem.API.Controllers
{
    [ApiController]
    [Route("api/v1/content/[controller]")]
    public class ParticipanteController : ControllerBase
    {
        public ParticipanteController()
        {

        }


        [HttpGet("{NúmeroInscrição}")]
        public IActionResult Get(string NúmeroInscrição)
        {
            return Ok("Hello World");
        }
    }
}
