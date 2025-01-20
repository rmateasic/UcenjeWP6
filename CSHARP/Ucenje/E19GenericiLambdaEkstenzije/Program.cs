using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E19GenericiLambdaEkstenzije
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("E19");
            // problem nizova: unaprijed znati broj elemenata. Rješenje je lista

            List<int> brojevi = new List<int>();

            brojevi.Add(7);
            brojevi.Add(2);
            //brojevi.Add("2"); ne može string jer mora int

            Console.WriteLine(brojevi[1]);

            var gradovi = new List<string>();

            gradovi.Add("Osijek");
            gradovi.Add("Zadar");

            foreach (string grad in gradovi)
            {
                Console.WriteLine(grad);
            }

            var smjerovi = new List<Smjer>();
            smjerovi.Add(new() { Naziv = "Web programiranje" });
            smjerovi.Add(new() { Naziv = "Autolimar" });

            var s = new Smjer();
            s.Sifra = 1;
            s.Naziv = "Serviser";
            smjerovi.Add(s);

            Console.WriteLine(smjerovi[0].StariNaziv());

            var o = new Obrada<Smjer>();

            o.ObjektObrade = s;

            //var o1 = new Obrada<string>(); ne možemo jer T u Obrada naslijeđuje Entitet

            //o1.ObjektObrade = "s";

            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            smjerovi.Sort(); // metoda koja se oslanja na Icomparable sučelje

            Console.WriteLine("***************");

            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            smjerovi.Reverse(); // okreni na drugu stranu

            Console.WriteLine("***************");

            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

        }
    }
}
