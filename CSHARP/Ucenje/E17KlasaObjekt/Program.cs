using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    internal class Program
    {
        // 5. vrsta metode (posebna) konstruktor
        // konstruktor mora imati isti naziv kao i klasa, a lista parametara može biti različita

        public Program()
        {
            // Objekt je instanca (pojavnost) klase

            // Osoba je ime klase (primjetiti veliko početno slovo O)
            // osoba je ime objekta (instance/pojavnosti) - varijable (primjetiti malo početno slovo o)
            Osoba osoba = new Osoba();

            osoba.Sifra = 1;

            //Osoba.Sifra = 1;

            // Osoba. Sifra na klasi ne postoji svojstvo, ono je na objektu

            osoba.Ime = "Pero"; //E12Metode.UcitajString("Unesi ime: ");
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.Ime);

            osoba = new Osoba() { 
                Sifra = 2, 
                Ime = "Karlo", 
                Prezime = "Lik"
            };

            Console.WriteLine("{0} {1}", osoba.Ime, osoba.Prezime);
            Console.WriteLine(osoba.ImePrezime());

            Osoba.Izvedi();
            //Console.WriteLine(osoba.Izvedi()); Ne možeš pozvati statičnu metodu na objektu (malo slovo o), već samo na klasi

            Mjesto mjesto = new Mjesto() { Naziv = "Osijek", PostanskiBroj = "31000" };

            //osoba.Mjesto = mjesto;

            // ispiši Osijek
            Console.WriteLine(osoba.Mjesto.Naziv);

        }


    }
}
