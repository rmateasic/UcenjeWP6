﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E10Z2");

            int b = 123456;

            bool prim = true;

            for (int i = 2; i < b; i++)
            {
                if (b % i == 0)
                {
                    prim = false;
                    break;
                }
            }
            Console.WriteLine(prim ? "DA" : "NE");
        }



    }
}
