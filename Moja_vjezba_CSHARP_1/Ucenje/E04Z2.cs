
namespace Ucenje
{
    internal class E04Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04Z2");

            Console.WriteLine("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj je paran");
            }
            else
            {
                Console.WriteLine("Broj je neparan");
            }
        }


    }
}
