using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GathaoWeb.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GathaoWeb.NetCore.Controllers
{
    public class IllustController : Controller
    {
        List<IllustListItem> illustItems;

        public IActionResult Index()
        {
            illustItems = new List<IllustListItem>();


            illustItems.Add(new IllustListItem()
            {
                Id = 0,
                ImageFilePath = "https://lh3.googleusercontent.com/63e6Yey0izxWCOyf4SEdafV_wjGRzRssmngIfr6J_Xn_fWDpaz8F1RHlyKZyN4_rCrwBoQN-HCzXOsJliV85m5S5x8VRwxHgL-st9_BNtmdXn4sElHoUZS9cmL0KZpVepJUR2WdzRtU=w2400?source=screenshot.guru",
                Tags = new List<string>() {
                    "fanart",
                    "voiceroid/cevio"
                }
            });

            illustItems.Add(new IllustListItem()
            {
                Id = 0,
                ImageFilePath = "https://lh3.googleusercontent.com/hy1f2hpr414wLaUkgkiZzdg66sF8Ny4gcoztbLKs5r-RgER0lwnNb3B5hBkzB93NQIO5CNI0yEmHca60Nhn8yPQq-Md_AZ59og3VhCEJ0or6b9YsWKU5Fj8JuOVCZq2KE_Yytdy18w8=w2400?source=screenshot.guru",
                Tags = new List<string>() {
                    "fanart",
                    "umamusume"
                }
            });

            ViewData["IllustItems"] = illustItems;

            return View();
        }
    }
}