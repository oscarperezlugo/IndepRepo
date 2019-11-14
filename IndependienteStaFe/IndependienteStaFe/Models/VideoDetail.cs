using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace IndependienteStaFe.Models
{
    public class VideoDetail
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data[] data { get; set; }


        public class Data
        {
            [JsonProperty("videoId")]
            public string VideoId { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("image")]
            public string Image { get; set; }
            [JsonProperty("profile")]
            public string Profile { get; set; }
            [JsonProperty("url")]
            public string Url { get; set; }
            [JsonProperty("Date")]
            public string Date { get; set; }
            
        }
    }
}

