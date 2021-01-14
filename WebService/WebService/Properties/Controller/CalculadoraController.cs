using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public int Sumag(int num1, int num2)
        {
            return num1+num2;
        }
        [HttpPost]
        public int Sumap([FromHeader]int num1, [FromHeader]int num2)
        {
            return num1 + num2;
        }
    }
}
