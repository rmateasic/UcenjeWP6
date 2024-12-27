

namespace Ucenje
{
    internal class E04Z1
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04Z1");

            Console.WriteLine("Unesite svoje godine: ");
            int godine = int.Parse(Console.ReadLine());
            if (godine >= 18)
            {
                Console.WriteLine("Punoljetan");
            }
            else
            {
                Console.WriteLine("Maloljetan");
            }

        }


    }
}
