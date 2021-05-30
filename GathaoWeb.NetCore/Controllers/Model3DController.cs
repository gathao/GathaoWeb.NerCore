using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GathaoWeb.NetCore.Controllers
{
    public class Model3DController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Honoka()
        {
            return View();
        }

        public IActionResult Kiritan()
        {
            return View();
        }
    }
}