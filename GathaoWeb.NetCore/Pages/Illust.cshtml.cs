using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GathaoWeb.NetCore.Model;

namespace GathaoWeb.NetCore.Pages
{
    public class IllustModel : PageModel
    {
        List<IllustListItem> illustItems;

        public void OnGet()
        {
            illustItems = new List<IllustListItem>();


            illustItems.Add(new IllustListItem() {
                Id = 0,
                imageFilePath = "https://lh3.googleusercontent.com/63e6Yey0izxWCOyf4SEdafV_wjGRzRssmngIfr6J_Xn_fWDpaz8F1RHlyKZyN4_rCrwBoQN-HCzXOsJliV85m5S5x8VRwxHgL-st9_BNtmdXn4sElHoUZS9cmL0KZpVepJUR2WdzRtU=w2400?source=screenshot.guru",
                tags = new List<string>() {
                    "fanart",
                    "voiceroid/cevio"
                }
            });

            foreach (var illustItem in illustItems)
            {

            }
        }
    }
}
