using Newtonsoft.Json;

namespace LifxSharp.Http.Requests
{
    public class TogglePowerRequest
    {
        [JsonProperty("duration")]
        public double? Duration { get; set; }
    }
}
