

namespace Ucenje
{
    internal class E09DoWhilePetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E09DoWhilePetlja");

            // provjera uvjeta je na kraju petlje i obavezno je jednom izvodi

            do
            {
                Console.WriteLine("Osijek");
            } while (false);


            // zbroj prvih 100 brojeva

            int i = 1, suma = 0;
            do
            {
                suma += i;
            } while (++i <= 100);

            Console.WriteLine(suma);
            // sve ostalo vrijedi kao i za for i while

        }


    }
}
