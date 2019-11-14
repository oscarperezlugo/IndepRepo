using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class ProductStock
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data[] data { get; set; }


        public class Data
        {
            [JsonProperty("attribute")]
            public string Attribute { get; set; }
            [JsonProperty("stock")]
            public string Stock { get; set; }

        }



    }
}
