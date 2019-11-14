using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class userPuntos
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("points")]
        public string Points { get; set; }
    }
}
