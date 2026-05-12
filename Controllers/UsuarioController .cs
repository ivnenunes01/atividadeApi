using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIVIDADE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATIVIDADE.Controllers
{
    [ApiController]
    [Route("usuario")]
    public class UsuarioController : ControllerBase
    {
        Usuario usuario = new Usuario() { Nome = "Flexa", Idade = 46 };

        [HttpGet]
        public IActionResult RetornarUsuario()
        {
            return Ok(usuario);
        }
    }
}