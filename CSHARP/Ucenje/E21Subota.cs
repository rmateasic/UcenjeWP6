using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E21Subota
    {
        public E21Subota()
        {
            //Console.WriteLine("Hello from E21Subota");

            SlucajniBrojevi();

        }

        private void SlucajniBrojevi()
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(20, 31));
            }
        }
    }

}
