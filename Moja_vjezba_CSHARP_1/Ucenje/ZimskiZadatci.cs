


using System;

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
            "Fibonaccijev niz",
            "Preokret stringa",
            "Brojanje samoglasnika",
            "Pretvorba temperature",
            "Sortiranje niza",
            "Kalkulator"
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

                case 5:
                    FibonaccijevNiz();
                    Izbornik();
                    break;

                case 6:
                    PreokretStringa();
                    Izbornik();
                    break;

                case 7:
                    BrojanjeSamoglasnika();
                    Izbornik();
                    break;

                case 8:
                    PretvorbaTemperature();
                    Izbornik();
                    break;

                case 9:
                    SortiranjeNiza();
                    Izbornik();
                    break;

                case 10:
                    Kalkulator();
                    Izbornik();
                    break;



            }
        }

        private static void Kalkulator()
        {
            NaslovPrograma("Kalkulator");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            Console.WriteLine();
            Console.WriteLine("+ (zbrajanje)");
            Console.WriteLine("- (oduzimanje)");
            Console.WriteLine("* (množenje)");
            Console.WriteLine("/ (dijeljenje)");
            Console.WriteLine();

            bool izlaz = false;

            while (!izlaz)
            {
                double x = E12Metode.UcitajCijeliBroj("Unesite prvi broj: ");
                double y = E12Metode.UcitajCijeliBroj("Unesite drugi broj: ");
                Console.Write("Odaberite operaciju (+, -, *, / (za izlaz upišite 0): ");
                char operacija = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (operacija)
                {
                    case '+':

                        Console.WriteLine();
                        Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                        Console.WriteLine();
                        break;

                    case '-':

                        Console.WriteLine();
                        Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                        Console.WriteLine();
                        break;

                    case '*':

                        Console.WriteLine();
                        Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                        Console.WriteLine();
                        break;

                    case '/':

                        Console.WriteLine();
                        Console.WriteLine("{0} / {1} = {2}", x, y, Math.Round(x / y, 2));
                        Console.WriteLine();
                        break;

                    case '0':
                        Console.WriteLine();
                        Console.WriteLine("Hvala na korištenju kalkulatora i doviđenja!");
                        Console.WriteLine();

                        izlaz = true;
                        break;

                    default:
                        Console.WriteLine("Nepoznata opcija, pokušajte ponovno!");
                        break;
                }
            }
        }

        private static void SortiranjeNiza()
        {
            NaslovPrograma("Sortiranje niza");

            int brojBrojeva = E12Metode.UcitajCijeliBroj("Koliko brojeva želite sortirati?  ");
            int[] brojevi = new int[brojBrojeva];

            Console.WriteLine("Unesite {0} brojeva u niz.", brojBrojeva);

            for (int i = 0; i < brojBrojeva; i++)
            {
                int broj = E12Metode.UcitajCijeliBroj($"Unesite {i + 1}. broj: ");
                brojevi[i] = broj;
            }

            Console.WriteLine();
            Console.Write("Unijeli ste: ");
            Console.WriteLine(string.Join(", ", brojevi));
            Console.WriteLine();
            Console.Write("Niz sortiran uzlazno: ");
            Array.Sort(brojevi);
            Console.Write(string.Join(", ", brojevi));
            Console.WriteLine();
            Console.Write("Niz sortiran silazno: ");
            Array.Reverse(brojevi);
            Console.Write(string.Join(", ", brojevi));
            Console.WriteLine();

        }

        private static void PretvorbaTemperature()
        {
            NaslovPrograma("Pretvorba temperature");

            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            Console.WriteLine("1. Pretvorba °C u °F");
            Console.WriteLine("2. Pretvorba °F u °C ");
            Console.WriteLine();
            switch (E12Metode.UcitajCijeliBroj("Odaberite opciju pretvorbe temperature: ", 0, 2))
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("1. Pretvorba °C u °F");
                    CelzijFahrenheit();
                    break;
                case 2:
                    Console.WriteLine("2. Pretvorba °F u °C");
                    FahrenheitCelzij();
                    break;
            }
        }

        private static void FahrenheitCelzij()
        {
            double fahrenheit = E12Metode.UcitajCijeliBroj("Unesite temperaturu u °F: ");
            double celsius = (fahrenheit - 32) / 1.8;
            Console.WriteLine("{0}°F = {1}°C", fahrenheit, celsius);
        }

        private static void CelzijFahrenheit()
        {
            double celsius = E12Metode.UcitajCijeliBroj("Unesite temperaturu u °C: ");
            double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("{0}°C = {1}°F", celsius, fahrenheit);
        }


        private static void BrojanjeSamoglasnika()
        {
            NaslovPrograma("Brojanje samoglasnika");

            int sum = 0;

            string[] samoglasnici = ["a", "e", "i", "o", "u"];
            string upis = E12Metode.UcitajString("Unesite riječ ili rečenicu: ");

            foreach (char slovo in upis)
            {
                if (String.Join("", samoglasnici).Contains(slovo))
                {
                    sum += 1;
                }
            }

            Console.WriteLine("U vašem upisu ima {0} ", sum + " samoglasnika.");
   
        }

        private static void PreokretStringa()
        {
            NaslovPrograma("Preokret stringa");

            string unos;

            while (true)
            {
                try
                {
                    unos = E12Metode.UcitajString("Unesite pojam ili niz znakova (2-20): ");

                    if (unos.Length < 2 || unos.Length > 20)
                    {
                        Console.WriteLine("Broj znakova je manji/veći od dozvoljenog, pokušajte ponovno!");
                        continue;
                    }
                    break;
                }
                catch
                {

                }
            }
            char[] preokret = new char[unos.Length];

            for (int i = 0; i < unos.Length; i++)
            {
                preokret[i] = unos[unos.Length - 1 - i];
            }

            Console.Write("Obrnuti redoslijed znakova je: ");
            Console.WriteLine(string.Concat(preokret));

        }

        private static void FibonaccijevNiz()
        {
            NaslovPrograma("Fibonaccijev niz");
            int n;

            while (true)
            {
                try 
                {
                    n = E12Metode.UcitajCijeliBroj("Unesite broj n za ispis prvih n brojeva Fibonaccijeva niza (2 - 10): ");

                    if (n < 2 || n > 10)
                    {
                        Console.WriteLine("Unešeni broj je izvan raspona, pokušajte ponovno!");
                        continue;
                    }
                    break;
                }
                catch
                {

                }
            }
            int[] niz = new int[n];
            niz[0] = 1;
            niz[1] = 1;

            for (int i = 2; i < n; i++)
            {
                niz[i] = niz[i - 1] + niz[i - 2];
            }

            if (n <= 4)
            {
                Console.Write("Prva {0} broja Fibonaccijeva niza: ", n);
            }
            else
            {
                Console.Write("Prvih {0} brojeva Fibonaccijeva niza: ", n);
            }

            Console.WriteLine(string.Join(", ", niz));
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
