using Newtonsoft.Json;

namespace LifxSharp.Http.Objects
{
    public class Capabilities
    {
        [JsonProperty("has_color")]
        public bool HasColor { get; set; }

        [JsonProperty("has_variable_color_temp")]
        public bool HasVariableColorTemp { get; set; }

        [JsonProperty("has_ir")]
        public bool HasIr { get; set; }

        [JsonProperty("has_chain")]
        public bool HasChain { get; set; }

        [JsonProperty("has_multizone")]
        public bool HasMultizone { get; set; }

        [JsonProperty("min_kelvin")]
        public int MinKelvin { get; set; }

        [JsonProperty("max_kelvin")]
        public int MaxKelvin { get; set; }
    }



}
