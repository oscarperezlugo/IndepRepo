using System;

namespace IndependienteStaFe.Models
{
    public class UserUpdate
    {
        public string token { get; set; }
        public string name { get; set; }
        public string Lastname { get; set; }
        public string Id { get; set; }
        public string Emal { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Cellnumber { get; set; }
        public string Gender { get; set; }
        public DateTime Birdhdate { get; set; }

        public bool Datapolicy { get; set; }
        public bool Termsandconditions { get; set; }
    }
}
