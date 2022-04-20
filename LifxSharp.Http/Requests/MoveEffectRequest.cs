using LifxSharp.Http.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Requests
{
    public class MoveEffectRequest
    {
        [JsonProperty("direction")]
        public Direction Direction { get; set; }
        [JsonProperty("period")]
        public double? Period { get; set; }

        [JsonProperty("cycles")]
        public double? Cycles { get; set; }
        [JsonProperty("persist")]
        public bool? Persist { get; set; }
        [JsonProperty("power_on")]
        public bool? PowerOn { get; set; }
        [JsonProperty("fast")]
        public bool? Fast { get; set; }
    }
}
