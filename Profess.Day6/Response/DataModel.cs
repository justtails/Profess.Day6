using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Profess.Day6.Response
{
    public class DataModel
    {
        [JsonProperty(PropertyName = "now")]
        public DateTime Now { get; set; }
        [JsonProperty(PropertyName = "temp")]
        public int Temp { get; set; }
        [JsonProperty(PropertyName = "feels_like")]
        public int FeelsLike { get; set; }
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }
    }
}
