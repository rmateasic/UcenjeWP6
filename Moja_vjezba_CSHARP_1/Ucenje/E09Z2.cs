

using System.Diagnostics.CodeAnalysis;

namespace Ucenje
{
    internal class E09Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E09Z2");

            int broj = 0;
            int suma = 0;

            while (true)
            {
                Console.WriteLine("Unesi brojeve dok ne uneseš -1:");
                broj = int .Parse(Console.ReadLine());

                if (broj == -1)
                {
                    break;
                }

                suma = suma + broj;




            }
            Console.WriteLine(suma);



        }


    }
}
