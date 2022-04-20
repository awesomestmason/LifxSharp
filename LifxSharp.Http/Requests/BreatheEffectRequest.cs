using Newtonsoft.Json;

namespace LifxSharp.Http.Requests
{
    public class BreatheEffectRequest
    {
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("from_color")]
        public string? FromColor { get; set; }
        [JsonProperty("period")]
        public double? Period { get; set; }
        [JsonProperty("cycles")]
        public double? Cycles { get; set; }
        [JsonProperty("persist")]
        public bool? Persist { get; set; }
        [JsonProperty("power_on")]
        public bool? PowerOn { get; set; }
        [JsonProperty("peak")]
        public double? Peak { get; set; }
    }
}
