using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class userInfo
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public Data data { get; set; }


        public class Data
        {
            [JsonProperty("id")]
            public string Id { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("lastname")]
            public string LastName { get; set; }
            [JsonProperty("email")]
            public string Email { get; set; }
            [JsonProperty("address")]
            public string Address { get; set; }
            [JsonProperty("city")]
            public string City { get; set; }

            [JsonProperty("cellnumber")]
            public string CellNumber { get; set; }

            [JsonProperty("gender")]
            public string Gender { get; set; }

            [JsonProperty("birthdate")]
            public string BirthDate { get; set; }
            [JsonProperty("profile")]
            public string Profile { get; set; }



        }
    }
}
