
namespace Ucenje
{
    internal class CiklicnaTablica
    {

        public static void Izvedi()
        {

            int redovi = UcitajBrojRedova("Upiši broj redova: ");

            int stupci = UcitajBrojStupaca("Upiši broj stupaca: ");

            int unesenaVrijednost = 0;

            int[,] tablica = new int[redovi, stupci];

            int vrijednost = 1;
            int max_vrijednost = redovi * stupci;

            int prviRed = 0;
            int prviStupac = 0;
            int zadnjiStupac = stupci - 1;
            int zadnjiRed = redovi - 1;


            while (vrijednost <= max_vrijednost)
            {
                //1.dolje desno prema lijevo
                for (int stup = zadnjiStupac; stup >= prviStupac && vrijednost <= max_vrijednost; stup--)
                {
                    tablica[zadnjiRed, stup] = vrijednost++;
                }
                zadnjiRed--;
                //2.dolje lijevo prema gore
                for (int redak = zadnjiRed; redak >= prviRed && vrijednost <= max_vrijednost; redak--)
                {
                    tablica[redak, prviStupac] = vrijednost++;
                }
                prviStupac++;
                //3.gore lijevo prema desno
                for (int stup = prviStupac; stup <= zadnjiStupac && vrijednost <= max_vrijednost; stup++)
                {
                    tablica[prviRed, stup] = vrijednost++;
                }
                prviRed++;
                //4.gore desno prema dolje
                for (int redak = prviRed; redak <= zadnjiRed && vrijednost <= max_vrijednost; redak++)
                {
                    tablica[redak, zadnjiStupac] = vrijednost++;
                }
                zadnjiStupac--;
            }
            // ispis tablice
            for (int redak = 0; redak < redovi; redak++)
            {
                for (int stup = 0; stup < stupci; stup++)
                {
                    Console.Write(string.Format("{0,4}", tablica[redak, stup]) + "\t");
                }
                Console.WriteLine();


            }
        }

        public static int UcitajBrojRedova(string poruka)
        {
            while (true)
            {
                Console.WriteLine(poruka);

                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if (broj >= 2 && broj <= 50)
                    {
                        return broj;
                    }
                    else
                    {
                        Console.WriteLine("Minimalan broj redaka je 2, a maksimalan 50! ");
                    }
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }

            }
        }
        public static int UcitajBrojStupaca(string poruka)
        {
            while (true)
            {
                Console.WriteLine(poruka);

                try
                {
                    int broj = int.Parse(Console.ReadLine());
                    if (broj >= 2 && broj <= 50)
                    {
                        return broj;
                    }
                    else
                    {
                        Console.WriteLine("Minimalan broj stupaca je 2, a maksimalan 50! ");
                    }
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }
        }
    }


}
  