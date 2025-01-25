﻿using System;
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
            //SlucajniDatumi();
            Ljubav();

        }

        private void Ljubav()
        {
            var ona = "Marta";
            var on = "Manuel";

            var izraz = ona.Trim().ToLower() + on.Trim().ToLower();

            Console.WriteLine(izraz);

            int[] brojevi = new int[izraz.Length];

            var ponovilose = 0;

            for (int i = 0; i < izraz.Length; i++)
            {
                ponovilose = 0;

                for (int j = 0; j < izraz.Length; j++)
                {
                    if (izraz[i] == izraz[j])
                    {
                        ponovilose++;
                    }
                }

                brojevi[i] = ponovilose;



            }

            Console.WriteLine(string.Join('|', izraz.ToArray()));
            Console.WriteLine(string.Join('|', brojevi));

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
