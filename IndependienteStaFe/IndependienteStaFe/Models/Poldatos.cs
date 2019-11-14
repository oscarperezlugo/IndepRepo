using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class Poldatos
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data[] data { get; set; }

        public class Data
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("content")]
            public string Content { get; set; }
        }

    }

}
