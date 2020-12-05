using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OperacionesNumero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumeroController : ControllerBase
    {

        //GET
        [HttpGet]
        public string OperacionGet(int numero)
        {
            if (numero < 0)
            {
                return "Error";
            }
            else { }

            if (numero == 0)
            {
                return "Realizado por Salma Eid";
            }
            else { }
            if (numero > 0)
            {return "Usted ingresó el número"; 
            
            }
            else { }
                return "No existe esa acción";
        }

        //POST
        [HttpPost]
        public string OperacionPost([FromHeader]int numero)
        {
            if (numero < 0)
            {
                return "Error";
            }
            else { }

            if (numero == 0)
            {
                return "Realizado por Salma Eid";
            }
            else { }
            if (numero > 0)
            {
                return "Usted ingresó el número";

            }
            else { }
            return "No existe esa acción";
        }




    }
}
