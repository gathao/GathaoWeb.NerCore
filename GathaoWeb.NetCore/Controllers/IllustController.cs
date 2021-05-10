using System.Collections.Generic;
using System.Threading.Tasks;
using GathaoWeb.NetCore.Commons;
using GathaoWeb.NetCore.Models;
using GathaoWeb.NetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GathaoWeb.NetCore.Controllers
{
    public class IllustController : Controller
    {
        List<IllustListItem> illustItems;

        public IllustController()
        {
        }

        public async Task<IActionResult> Index()
        {
            illustItems = await GathaoWebContentsService.GetIllustItems();
            ViewData["IllustItems"] = illustItems;

            return View();
        }
    }
}