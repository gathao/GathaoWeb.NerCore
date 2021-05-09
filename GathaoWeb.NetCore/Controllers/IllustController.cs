using System.Collections.Generic;
using System.Threading.Tasks;
using GathaoWeb.NetCore.Models;
using GathaoWeb.NetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GathaoWeb.NetCore.Controllers
{
    public class IllustController : Controller
    {
        private readonly IConfiguration Configuration;

        List<IllustListItem> illustItems;

        public IllustController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            var key = Configuration["APIKeys"];

            illustItems = await GathaoWebContentsService.GetIllustItems();
            ViewData["IllustItems"] = illustItems;

            return View();
        }
    }
}