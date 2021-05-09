using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GathaoWeb.NetCore.Model
{
    public class IllustListItem
    {
        public int Id { get; set; }

        public string imageFilePath { get; set; }

        public List<string> tags { get; set; }
    }
}
