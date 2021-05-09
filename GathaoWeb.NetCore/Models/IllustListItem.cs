using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GathaoWeb.NetCore.Models
{
    public class IllustListItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageFilePath")]
        public string ImageFilePath { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}
