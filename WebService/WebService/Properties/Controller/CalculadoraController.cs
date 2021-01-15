using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Properties.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CalculadoraController : Controller
    {
        [HttpGet]
        [Route("suma")]
        public int Sumag(int num1, int num2)
        {
            return num1+num2;
        }
        [HttpPost]
        [Route("suma")]
        public int Sumap([FromHeader]int num1, [FromHeader]int num2)
        {
            return num1 + num2;
        }


        [HttpGet]
        [Route("resta")]
        public int Restag(int num1, int num2)
        {
            return num1 - num2;
        }
        [HttpPost]
        [Route("resta")]
        public int Restap([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 - num2;
        }

        [HttpGet]
        [Route("multiplicacion")]
        public int Multiplicaciong(int num1, int num2)
        {
            return num1 * num2;
        }
        [HttpPost]
        [Route("multiplicacion")]
        public int Multiplicacionp([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 * num2;
        }

    }
}
