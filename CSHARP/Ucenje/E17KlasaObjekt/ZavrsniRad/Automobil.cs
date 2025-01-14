using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    public class Automobil
    {
        public int Sifra { get; set; }

        public string NazivAuta { get; set; } = "";

        public string? Gorivo { get; set; } = "";

        public string Model { get; set; } = "";

        public int? Godiste { get; set; }

        public Prozvodjac Prozvodjac { get; set; } = new Prozvodjac();

        public VrstaAuta VrstaAuta { get; set; } = new VrstaAuta();



    }
}
