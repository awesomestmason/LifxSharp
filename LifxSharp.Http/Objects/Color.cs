using Newtonsoft.Json;

namespace LifxSharp.Http.Objects
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Color
    {
        [JsonProperty("hue")]
        public double Hue { get; set; }

        [JsonProperty("saturation")]
        public double Saturation { get; set; }

        [JsonProperty("kelvin")]
        public int Kelvin { get; set; }
    }



}
