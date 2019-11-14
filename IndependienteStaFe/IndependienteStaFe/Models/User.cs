using System;

namespace IndependienteStaFe.Models
{
    public class User
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string cellnumber { get; set; }
        public string gender { get; set; }
        public DateTime birdhdate { get; set; }

        public bool datapolicy { get; set; }
        public bool termsandconditions { get; set; }


    }
}
