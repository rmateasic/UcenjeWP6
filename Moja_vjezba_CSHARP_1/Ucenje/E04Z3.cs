
namespace Ucenje
{
    internal class E04Z3
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04Z3");

            int i = 0, j = 0, l = 0;

            Console.WriteLine("Unesi 1. cijeli broj: ");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 2. cijeli broj: ");
            j = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 3. cijeli broj: ");
            l = int.Parse(Console.ReadLine());

            if (i < j && i < l)
            {
                Console.WriteLine("Najmanji broj je {0}. ", i);
            }
            else if (j < i && j < l)
            {
                Console.WriteLine("Najmanji broj je {0}. ", j);
            }
            else if (l < i && l < j)
            {
                Console.WriteLine("Najmanji broj je {0}. ", l);
            }
            else
            {
                Console.WriteLine("Jednaki brojevi. ");
            }


        }

    }
}
