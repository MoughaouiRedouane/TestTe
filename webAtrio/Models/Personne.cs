using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAtrio.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
    }
}
