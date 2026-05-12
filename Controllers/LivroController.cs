using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIVIDADE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATIVIDADE.Controllers
{
    [ApiController]
    [Route("Livro")]
    public class LivroController : ControllerBase
    {
        List<Livro> Livro = new List<Livro>
        {
            new Livro {Nome = "Imperfeitos", Paginas = 289}, 
            new Livro {Nome = "Não é como nos filmes", Paginas = 416},
            new Livro {Nome = "Melhor que nos filmes", Paginas = 352},
            new Livro {Nome = "O lado feio do amor", Paginas = 336},
            new Livro {Nome = "Quarta Asa", Paginas = 544},
            new Livro {Nome = "Cutelo e o Corvo", Paginas = 320}

        };

        [HttpGet]
        public ActionResult<IEnumerable<Livro>> GetLivro()
        {
            return Ok(Livro);
        }
        
    }
}