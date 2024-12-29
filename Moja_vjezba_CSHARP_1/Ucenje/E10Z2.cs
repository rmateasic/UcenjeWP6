
namespace Ucenje
{
    internal class E10Z2
    {

        // Za uneseni cijeli broj program provjerava da li je prim broj (prime number), prosti broj

        public static void Izvedi()
        {
            //Console.WriteLine("E10Z2");

            int b = 11;

            bool prim = true;

            for (int i = 2; i < b; i++)
            {
                if (b % i == 0)
                {
                    prim = false;
                    //break;

                }

            }
        }
    }
}

