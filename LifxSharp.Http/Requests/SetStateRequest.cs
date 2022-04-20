using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Requests
{
    public class SetStateRequest
    {
        [JsonProperty("power")]
        public bool? Power { get; set; }
        [JsonProperty("color")]
        public string? Color { get; set; }
        [JsonProperty("brightness")]
        public double? Brightness { get; set; }
        [JsonProperty("duration")]
        public double? Duration { get; set; }
        [JsonProperty("infrared")]
        public double? Infrared { get; set; }
        [JsonProperty("fast")]
        public bool? Fast { get; set; }
    }
}
