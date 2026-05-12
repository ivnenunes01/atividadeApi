using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ATIVIDADE.Controllers
{
    [ApiController]
    [Route("Filme")]
    public class FilmeController : ControllerBase
    {
       [HttpGet]
       public string get()
        {
            return "Vingadores, Matrix, Interestelar";
        }
        
    }
}