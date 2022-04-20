using Newtonsoft.Json;

namespace LifxSharp.Http.Requests
{
    public class SetStatesRequest
    {
        [JsonProperty("states")]
        public SetStateRequest[] States { get; set; }

        [JsonProperty("defaults")]
        public SetStateRequest Defaults { get; set; }

    }
}
