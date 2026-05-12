using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ATIVIDADE.Controllers
{
    [ApiController]
    [Route("Status")]
    public class StatusController
    {
        [HttpGet]
        public string get()
        {
            return "API Online";
        }
        
    }
}