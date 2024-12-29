
using System.Threading.Channels;

namespace Ucenje
{
    internal class E13Z1
    {

        // Program od korisnika unosi cijeli broj koji mora biti veći od 0 i manji od 10
        // Program ispisuje faktorijel od unesenog broja (npr. 2*3*4*5*6 za uneseni broj 6)

        public static void Izvedi()
        {
            //Console.WriteLine("E13Z1");

            int broj = UcitajCijeliBroj("Unesi broj: ");
            Console.WriteLine(Mnozi(broj));
        }

        public static int UcitajCijeliBroj(string poruka)
        {

            while (true)
            {
                Console.Write(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }


            //return 0; // kasnije obrisati
        }
        private static int Mnozi(int broj)
        {
            if (broj > 1 && broj < 10)
            {
                return broj * Mnozi(broj - 1);
            }
            //return broj * Mnozi(broj - 1);
            return broj;

        }

    }
}
