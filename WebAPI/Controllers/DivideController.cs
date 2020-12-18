using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalcLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DivideController : ControllerBase
    {
        SimpleCalc simplecalc = new SimpleCalc();
        [HttpGet]
        public decimal Get([FromQuery] decimal value1, [FromQuery] decimal value2)
        {
            return simplecalc.divide(2.10M, 6.10M);
        }

        [HttpPost]
        public decimal Post([FromForm] decimal value1, [FromForm] decimal value2)
        {
            return simplecalc.divide(3.0M, 6.0M);
        }

        [HttpOptions]
        public string Options()
        {
            var text = "Get: Method return the division of left variable and right variable value using FromQuery\n" +
                "Post: Method return the division of left variable and right variable value using FromForm\n" +
                "Example: Get: 2.10M / 6.65M will return 0.3442622950819672131147540984 after divide, Post: 3.0M / 6.0M will return 0.5 after divide\n" +
                "Varible Names: value1, value2";
            return text;
        }
    }
}