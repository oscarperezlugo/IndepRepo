﻿using Newtonsoft.Json;

namespace IndependienteStaFe.Models
{
    public class RegisterPay
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}