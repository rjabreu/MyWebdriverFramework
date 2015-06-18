using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebdriverFramework.Model
{
    class WebElement
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("path")]
        public string path { get; set; }
    }
}
