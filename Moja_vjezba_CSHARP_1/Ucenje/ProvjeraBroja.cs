

namespace Ucenje
{
    internal class ProvjeraBroja
    {

        public static void Izvedi()
        {
            //Console.WriteLine("ProvjeraBroja");

            int broj = 0;

            Console.WriteLine("Unesi cijeli broj: ");
            broj = int.Parse(Console.ReadLine());

            if (broj > 0)
            {
                Console.WriteLine("Broj je pozitivan. ");
            } 
            else if (broj < 0)
            {
                Console.WriteLine("Broj je negativan. ");
            }
            else
            {
                Console.WriteLine("Broj je nula. ");
            }
        }

    }
}
