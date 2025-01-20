﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E19GenericiLambdaEkstenzije
{
    // T je tipe, može ići bilo koje slovo
    public class Obrada<T> : ISucelje where T : Entitet
    {
        public T? ObjektObrade { get; set; }

        public List<T>? ListaObrade { get; set; }

        public void OdradiPosao()
        {
            Posao();
        }

        public void Posao()
        {
            Console.WriteLine(ObjektObrade?.Sifra);
        }

    }
}
