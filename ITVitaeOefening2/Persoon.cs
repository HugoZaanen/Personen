using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVitaeOefening2
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Geboortedatum { get; set; }
        public GeslachtEnum Geslacht { get; set; }
        public string Land { get; set; }
    }

    public enum GeslachtEnum
    {
        Man,
        Vrouw,
        Onbekend
    }
}
