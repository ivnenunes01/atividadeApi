using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIVIDADE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATIVIDADE.Controllers
{
    [ApiController]
    [Route("carro")]
    public class CarroController : ControllerBase
    {
        List<Carro> carro = new List<Carro>
       {
            new Carro {Modelo = "civic",Marca = "honda"},
            new Carro {Modelo = "saveiro",Marca = "Volkswagen"}
       };

        [HttpGet]
        public ActionResult<IEnumerable<Aluno>> GetAlunos()
        {
            return Ok(carro);
        }
    }
}