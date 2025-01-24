﻿using Microsoft.Extensions.Logging.Abstractions;

namespace WebAPI9.Models
{
    public class Osoba
    {

        public int Sifra { get; set; }

        public string? Ime { get; set; }

        public decimal Koeficijent { get; set; }

        public DateTime? DatumRodenja { get; set; }

        public bool Aktivan { get; set; }


    }
}
