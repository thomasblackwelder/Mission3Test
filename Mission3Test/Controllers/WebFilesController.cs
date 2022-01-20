using Microsoft.AspNetCore.Mvc;
using Mission3Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3Test.Controllers
{
    public class WebFilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Calculator ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculator (CalculatorModel model)
        {
            return View();
        }
    }
}
