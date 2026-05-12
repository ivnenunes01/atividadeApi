using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIVIDADE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATIVIDADE.Controllers
{
    [ApiController]
    [Route("Time")]
    public class TimeController : ControllerBase
    {
        List<Time> Time = new List<Time>
        {
            new Time {Nome = "Corinthians o MELHOR", Pontos = 72},
            new Time {Nome = "Vasco", Pontos = 65},
            new Time {Nome = "Gremio", Pontos = 50},
            new Time {Nome = "Internacional", Pontos = 17}

        };
        [HttpGet]
        public ActionResult<IEnumerable<Time>> GetTime()
        {
            return Ok(Time);
        }
    }
}