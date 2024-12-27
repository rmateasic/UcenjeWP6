using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E09Z1
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E09Z1");

            Console.WriteLine("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            int i = 1;
            int suma = 0;

            while (i <= broj)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
                i++;
            }
            Console.WriteLine(suma);
        }


    }
}
