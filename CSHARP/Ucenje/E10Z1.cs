using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z1
    {

        public static void Izvedi()
        {
            //Console.WriteLine("10");

            Console.Write("Unesi izraz: ");

            string Izraz = Console.ReadLine();

            Console.WriteLine(Izraz);

            if (Izraz.Length % 2 == 0 )
            {
                Console.WriteLine("parno");

                bool palindrom = true;

                for (int i = 0; i < Izraz.Length / 2; i++)
                {
                    if(Izraz[i] != Izraz[Izraz.Length - 1 - i])
                    {
                        palindrom = false; 
                        break;
                    }
                }
                Console.WriteLine(palindrom ? "DA" : "NE");
            }else
            {
                Console.WriteLine("neparno");
            }
        }


    }
}
