using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIVIDADE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATIVIDADE.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoController : ControllerBase
    {
        List<Aluno> alunos = new List<Aluno>
        {
            new Aluno {Nome = "Flexa",Idade = 46},
            new Aluno {Nome = "Ivne",Idade = 18}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Aluno>> GetAlunos()
        {
            return Ok(alunos);
        }

    }
}