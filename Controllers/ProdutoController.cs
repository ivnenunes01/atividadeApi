using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIVIDADE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATIVIDADE.Controllers
{
    [ApiController]
    [Route("Produto")]
    public class ProdutoController : ControllerBase  
    {
       List<Produto> produto = new List<Produto>
       {
            new Produto {Nome = "TV",Preco = 1.850},
            new Produto {Nome = "Notebook",Preco = 2.200}      
       };

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetProduto()
        {
            return Ok(produto);
        }
        
    }
}
