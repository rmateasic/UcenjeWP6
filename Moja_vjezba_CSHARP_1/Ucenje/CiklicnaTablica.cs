
namespace Ucenje
{
    internal class CiklicnaTablica
    {

        public static void Izvedi()
        {

            Console.WriteLine("Upiši broj redova: ");
            int redovi = int.Parse(Console.ReadLine());

            Console.WriteLine("Upiši broj stupaca: ");
            int stupci = int.Parse(Console.ReadLine());

            int unesenaVrijednost = 0;

            int[,] tablica = new int[redovi, stupci];

            int vrijednost = 1;
            int max_vrijednost = redovi * stupci;

            int desnaGranica = stupci - 1;
            int donjaGranica = redovi - 1;
            int gornjaGranica = 0;
            int lijevaGranica = 0;


            while (vrijednost <= max_vrijednost)
            {
                //1.dolje desno prema lijevo
                for (int stup = desnaGranica; stup >= lijevaGranica && vrijednost <= max_vrijednost; stup--)
                {
                    tablica[donjaGranica, stup] = vrijednost++;
                }
                donjaGranica--;
                //2.dolje lijevo prema gore
                for (int redak = donjaGranica; redak >= gornjaGranica && vrijednost <= max_vrijednost; redak--)
                {
                    tablica[redak, lijevaGranica] = vrijednost++;
                }
                lijevaGranica++;
                //3.gore lijevo prema desno
                for (int stup = lijevaGranica; stup <= desnaGranica && vrijednost <= max_vrijednost; stup++)
                {
                    tablica[gornjaGranica, stup] = vrijednost++;
                }
                gornjaGranica++;
                //4.gore desno prema dolje
                for (int redak = gornjaGranica; redak <= donjaGranica && vrijednost <= max_vrijednost; redak++)
                {
                    tablica[redak, desnaGranica] = vrijednost++;
                }
                desnaGranica--;
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
    }

}
  