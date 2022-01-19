using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Objects
{

    public class Bulb
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("connected")]
        public bool Connected { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("color")]
        public Color Color { get; set; }

        [JsonProperty("brightness")]
        public double Brightness { get; set; }

        [JsonProperty("effect")]
        public string Effect { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("product")]
        public Product Product { get; set; }

        [JsonProperty("last_seen")]
        public DateTime LastSeen { get; set; }

        [JsonProperty("seconds_since_seen")]
        public int SecondsSinceSeen { get; set; }
    }



}
