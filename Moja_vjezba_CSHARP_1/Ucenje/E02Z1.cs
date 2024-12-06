using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Napišite program koji unosi broj godina

    // Program ispisuje: Osoba XXXXX ima YY godina

    internal class E02Z1
    {
        // Ova metoda je uvijek potrebna ( za sada "kucamo" ručno)
        public static void Izvedi()
        {

            // ovdje se piše rješenje zadatka
            Console.Write("Unesi ime; ");
            string ime = Console.ReadLine();
            Console.Write("Unesi broj godina (cijeli broj): ");
            int godine = int.Parse(Console.ReadLine());

            Console.WriteLine("Osoba {0} ima {1} godina.", ime, godine);

        }



    }
}
