

namespace Ucenje
{
    internal class IzracunPovrsinePravokutnika
    {

        public static void Izvedi()
        {
            //Console.WriteLine("IzracunPovrsinePravokutnika");

            int duljina = 0;
            int sirina = 0;

            Console.WriteLine("Unesi duljinu pravokutnika: ");
            duljina = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi širinu pravokutnika: ");
            sirina = int.Parse(Console.ReadLine());

            Console.WriteLine("Površina pravokutnika je: {0} ", duljina * sirina);

        }

    }
}
