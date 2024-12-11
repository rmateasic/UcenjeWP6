using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10ForeachPetlja
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E10");

            Console.Write("Unesi ime svog grada: ");

            string grad = Console.ReadLine();

            Console.WriteLine(grad);

            // string je niz znakova char[]
            //za Osijek

            char[] znakoviGrad = new char[6];
            znakoviGrad[0] = 'O';
            znakoviGrad[1] = 's';
            znakoviGrad[2] = 'i';
            znakoviGrad[3] = 'j';
            znakoviGrad[4] = 'e';
            znakoviGrad[5] = 'k';

            for (int i = 0; i < 6; i++)
            {
                Console.Write(znakoviGrad[i]);
            }

            for (int i = 0; i < grad.Length; i++)
            {
                Console.Write(grad[i]);
            }

            foreach(char znak in znakoviGrad)
            {
                Console.Write(znak);
            }

            foreach(char c in grad)
            {
                Console.Write(c);
               
            }

           

            // ispiši uneseni grad unazad
            // Valpovo

            for(int i = grad.Length - 1; i >= 0; i--)
            {
                Console.Write(grad[i]);
            }



        }
    }
}
