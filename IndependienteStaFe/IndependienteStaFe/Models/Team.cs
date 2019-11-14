using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class Team
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data[] data { get; set; }

        public class Data
        {
            [JsonProperty("teamId")]
            public string TeamId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("shield")]
            public string Shield { get; set; }
        }
    }
}
