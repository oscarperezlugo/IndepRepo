using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class Perfiles
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
        }
    }
}
