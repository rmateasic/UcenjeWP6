﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    public abstract class Entitet : Object
    {
        public int Sifra { get; set; }

        public override string ToString()
        {
            return Sifra.ToString();
        }
        

    }
}
