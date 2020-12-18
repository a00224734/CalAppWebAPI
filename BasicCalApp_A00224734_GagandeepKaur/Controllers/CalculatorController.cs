using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BasicCalApp_A00224734_GagandeepKaur.Models;
using CalcLibrary;

namespace BasicCalApp_A00224734_GagandeepKaur.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: CalculatorController
        public ActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult Index(Calculator calculator, string operate)
        {
            SimpleCalc simplecalc = new SimpleCalc();
            calculator.result = simplecalc.OperatorSwitch(calculator.value1, calculator.value2, operate);
            return View(calculator);
        }
    }
}