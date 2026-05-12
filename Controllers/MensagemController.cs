using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ATIVIDADE.Controllers
{
    [ApiController]
    [Route("mensagem")]
    public class MensagemController : ControllerBase
    {
        [HttpGet]
        public string get()
        {
            return "Bem-vindo à API .NET 8";
        }
    }
}