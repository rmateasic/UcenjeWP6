

namespace Ucenje
{
    internal class E13Rekurzija
    {

        // Rekurzija je kada metoda zove samu sebe
        // UZ UVIJET PREKIDA REKURZIJE

        public static void Izvedi()
        {
            //Console.WriteLine("E13Rekurzija");

            // Izvedi(); // Ovdje dobijemo Stack overflow https://stackoverflow.com/

            Console.WriteLine(Zbroji(100));

        }

        private static int Zbroji(int broj)
        {
            if (broj == 1)
            {
                return 1;
            }
            return broj + Zbroji(broj - 1);
        }
        // 100 + 99 + 98 + 97 + ... + 1
    }

}

