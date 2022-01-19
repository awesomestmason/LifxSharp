using Newtonsoft.Json;

namespace LifxSharp.Http.Objects
{
    public class Product
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("capabilities")]
        public Capabilities Capabilities { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("vendor_id")]
        public int VendorId { get; set; }
    }



}
