using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class Membership
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data[] data { get; set; }


        public class Data
        {
            [JsonProperty("id")]
            public string Id { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("cost")]
            public string Cost { get; set; }
            [JsonProperty("money")]
            public string Money { get; set; }
            [JsonProperty("content")]
            public string Content { get; set; }

        }
    }
}
