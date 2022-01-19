using Newtonsoft.Json;

namespace LifxSharp.Http.Objects
{
    public class Location
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }



}
