﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.Edunova
{
    public class Polaznik
    {
        public int Sifra { get; set; }

        public string Ime { get; set; } = "";

        public string Prezime { get; set; } = "";

        public string Email { get; set; } = "";

        public string? OIB { get; set; }

        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }

    }
}
