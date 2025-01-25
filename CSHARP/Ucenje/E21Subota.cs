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

            //SlucajniBrojevi();
            SlucajniDatumi();

        }

        private void SlucajniBrojevi()
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(20, 31));
            }
        }

        private void SlucajniDatumi()
        {
            var rnd = new Random();


            for (int i = 0; i < 100; i++)
            {

                try
                {
                    var d = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 32));
                    Console.WriteLine((i + 1) + ":" + d.ToString("yyyy-MM-dd"));
                }
                catch
                {
                    i--;
                }
            }


        }
    }

}
