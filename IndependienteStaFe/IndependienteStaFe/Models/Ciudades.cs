using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class Ciudades
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data[] data { get; set; }


        public class Data
        {
            [JsonProperty("Id")]
            public string id { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}
