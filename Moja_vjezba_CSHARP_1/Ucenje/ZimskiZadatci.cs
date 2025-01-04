


namespace Ucenje
{
    internal class ZimskiZadatci
    {

        public static void Izvedi()
        {
            //Console.WriteLine("ZimskiZadatci");

            Izbornik();
        }

        private static void Izbornik()
        {
            string[] programi =
            {
            "Izračun površine pravokutnika",
            "Pozitivan ili negativan broj?",
            "Zbroj elemenata niza",
            "Prosjek ocjena",
            "Fibonaccijev niz"
            };

            Console.WriteLine();
            Console.WriteLine("IZBORNIK:");
            Console.WriteLine();

            for (int i = 0; i < programi.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, programi[i]);
            }

            Console.WriteLine("0. Izlaz iz programa");
            Console.WriteLine();
            OdabirOpcijeIzbornika(programi.Length);
        }

        private static void OdabirOpcijeIzbornika(int brojPrograma)
        {

            switch (E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika: ", 0, brojPrograma ))
            {
                case 0:
                    break;

                case 1:
                    IzracunPovrsinePravokutnika();
                    Izbornik();
                    break;

                case 2:
                    PozitivanIliNegativanBroj();
                    Izbornik();
                    break;

                    case 3:
                    ZbrojElemenataNiza();
                    Izbornik();
                    break;

                case 4:
                    ProsjekOcjena();
                    Izbornik();
                    break;  



            }
        }

        private static void ProsjekOcjena()
        {
            NaslovPrograma("Prosjek ocjena");

            int brojOcjena;

            while (true)
            {
                try
                {
                    Console.WriteLine("Unesi željeni broj ocjena (najviše 10): ");
                    brojOcjena = int.Parse(Console.ReadLine());
                    if (brojOcjena < 1 || brojOcjena > 10)
                    {
                        Console.WriteLine("Nisi unio dobar broj, pokušaj ponovno!");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Nisi dobro unio broj!");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Broj ocjena je {0}. Sad unesi jednu po jednu ocjenu: ", brojOcjena);

            int[] niz = new int[brojOcjena];
            int sum = 0;

            for (int i = 0; i < brojOcjena; i++)
            {

                int ocjena = E12Metode.UcitajCijeliBroj($"Unesi ocjenu broj {i + 1}: ");
                niz[i] = ocjena;
                sum += ocjena;

            }

            decimal prosjek = (decimal)sum / brojOcjena;
            prosjek = Math.Round(prosjek, 2);

            Console.WriteLine();
            Console.Write("Unio si sljedeće ocjene: ");
            Console.WriteLine(string.Join(", ", niz));
            Console.Write($"Prosjek ocjena je {prosjek}");
            Console.WriteLine();

        }

        

        private static void ZbrojElemenataNiza()
        {
            NaslovPrograma("Zbroj elemenata niza");

            int velicinaNiza;

            while (true)
            {
                try
                {
                    Console.Write("Unesi željeni broj cijelih brojeva u nizu (2 - 20): ");
                    velicinaNiza = int.Parse(Console.ReadLine());
                    if (velicinaNiza < 2 || velicinaNiza > 20)
                    {
                        Console.WriteLine("Nisi unio dobar broj, pokušaj ponovno!");
                        continue;
                    }
                    break;

                }
                catch
                {
                    Console.WriteLine("Nisi dobro unio broj!");
                }

            }
            Console.WriteLine();
            Console.WriteLine("U redu, broj članova niza je {0}. Sad unesi jedan po jedan broj.", velicinaNiza);

            int[] niz = new int[velicinaNiza];
            int sum = 0;

            for (int i = 0; i < velicinaNiza; i++)
            {
                int broj = E12Metode.UcitajCijeliBroj($"Unesi {i + 1}. broj: ");
                niz[i] = broj;
                sum += broj;
            }


            Console.WriteLine();
            Console.Write("Unio si sljedeći niz: ");
            Console.WriteLine(string.Join(", ", niz));
            Console.WriteLine($"Zbroj elemenata ovog niza je {sum}. ");

        }

        private static void NaslovPrograma(string naslov)
        {
            Console.WriteLine(naslov);
        }

        private static void PozitivanIliNegativanBroj()
        {
            NaslovPrograma("Pozitivan ili negativan broj?");
            int i = E12Metode.UcitajCijeliBroj("Unesi cijeli broj:");
            if (i > 0)
            {
                Console.WriteLine("Broj je pozitivan!");
            }
            else if (i < 0)
            {
                Console.WriteLine("Broj je negativan!");  
            }
            else
            {
                Console.WriteLine("Broj je 0!");
            }
        }

        private static void IzracunPovrsinePravokutnika()
        {
            NaslovPrograma("Izračun površine pravokutnika");
            int a = E12Metode.UcitajCijeliBroj("Unesi duljinu pravokutnika: ");
            int b = E12Metode.UcitajCijeliBroj("Unesi širinu pravokutnika: ");

            Console.WriteLine("Površina pravokutnika duljina stranica {0} i {1} je {2}", a, b, a * b);
        }
    }
}
