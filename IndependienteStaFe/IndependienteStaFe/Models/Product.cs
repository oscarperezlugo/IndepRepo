using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class Product
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data[] data { get; set; }


        public class Data
        {
            [JsonProperty("productId")]
            public string ProductId { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("description")]
            public string Description { get; set; }
            [JsonProperty("image")]
            public string Image { get; set; }
            [JsonProperty("date")]
            public string Date { get; set; }
            [JsonProperty("typePay")]
            public string TypePay { get; set; }

            [JsonProperty("points")]
            public string Points { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }
        }

    }
}
