using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GathaoWeb.NetCore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult YukariHomerun()
        {
            return View();
        }

        public IActionResult Suzumari()
        {
            return View();
        }

        public IActionResult VoiceRoid()
        {
            return View();
        }
    }
}