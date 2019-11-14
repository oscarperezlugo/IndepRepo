using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{

    public class Game
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data[] data { get; set; }

        public class Data
        {
            [JsonProperty("gameName")]
            public string GameName { get; set; }

            [JsonProperty("localTeamId")]
            public string LocalTeamId { get; set; }

            [JsonProperty("localTeamName")]
            public string LocalTeamName { get; set; }

            [JsonProperty("localShield")]
            public string LocalShield { get; set; }

            [JsonProperty("visitorTeamId")]
            public string VisitorTeamId { get; set; }

            [JsonProperty("visitorTeamName")]
            public string VisitorTeamName { get; set; }

            [JsonProperty("visitorShield")]
            public string VisitorShield { get; set; }

            [JsonProperty("stadium")]
            public string Stadium { get; set; }
            [JsonProperty("dateGame")]
            public string DateGame { get; set; }

            [JsonProperty("bonusGame")]
            public string BonusGame { get; set; }

        }
    }
}
