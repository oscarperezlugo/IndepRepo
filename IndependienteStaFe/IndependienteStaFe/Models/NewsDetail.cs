using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class NewsDetail
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data[] data { get; set; }


        public class Data
        {
            [JsonProperty("newsId")]
            public string NewsId { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("content")]
            public string Content { get; set; }
            [JsonProperty("image")]
            public string Image { get; set; }
            [JsonProperty("date")]
            public string Date { get; set; }
            [JsonProperty("profile")]
            public string Profile { get; set; }
        }
    }
}
