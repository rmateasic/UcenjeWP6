

namespace Ucenje
{
    internal class E07Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E07Z2");

            Console.WriteLine("Unesi 1. cijeli broj: ");
            int broj1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 2. cijeli broj: ");
            int broj2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Brojevi između {0} i {1} su: ", broj1, broj2);

            if (broj1 < broj2)
            {
                for (int i = broj1; i <= broj2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (broj1 > broj2) 
            {
                for(int i = broj1; i >= broj2; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Greška, unijeli ste iste brojeve. ");
            }
        }


    }
}
