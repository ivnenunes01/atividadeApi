using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIVIDADE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATIVIDADE.Controllers
{
    [ApiController]
    [Route("cidade")]
    public class CidadeController : ControllerBase
    {
        Cidade cidade = new Cidade() { Nome = "Caxias do Sul", Populacao = "520 mil habitantes" };
        [HttpGet]
        public IActionResult RetornarCidade()
        {
            return Ok(cidade);
        }

    }
}