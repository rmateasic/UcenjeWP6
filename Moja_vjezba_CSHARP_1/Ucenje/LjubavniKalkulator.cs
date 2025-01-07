

using System.Threading.Channels;

namespace Ucenje
{
    internal class LjubavniKalkulator
    {

        /*Ljubavni kalkulator
    Napraviti osnovni zadatak prema inicijalnoj slici koristeći rekurziju

    Dodatno:
            Osigurati unos imena(smije imati samo slova, bez brojeva i interpunkcijskih znakova)
    promijeniti algoritam da zbraja dva susjedna broja(1 i 2, 3 i 4, 5 i 6, itd.) umjesto osnovnog algoritma 1 i zadnji, drugi i predzadnji itd.
    Umjesto rekurzije koristiti petlju po izboru*/


        public static void Izvedi()
        {
            //Console.WriteLine("Ljubavni Kalkulator");

            //Osnovni zadatak, rekurzija

            Console.WriteLine("Dobro došli u Ljubavni kalkulator!");

            string ime1 = E12Metode.UcitajString("Unesi svoje ime: ").ToUpper();
            string ime2 = E12Metode.UcitajString("Unesi ime svoje simpatije: ").ToUpper();

            {
                int rezultat = LjubavnaKalkulacija(ime1, ime2);
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%", ime1, ime2, rezultat);
            }
            
        }
        private static int LjubavnaKalkulacija(string ime1, string ime2)
        {
            char[] imena = (ime1 + ime2).ToCharArray();

            Dictionary<char, int> imenabrojevi = new Dictionary<char, int>();

            foreach (char slovo in imena)
            {
            if(imenabrojevi.ContainsKey(slovo))
                {
                    imenabrojevi[slovo]++;
                }
            else
                {
                    imenabrojevi[slovo] = 1;
                }
            }

            int[] brojPonavljanja = new int[imena.Length];

            for (int i = 0; i < imena.Length; i++)
            {
                brojPonavljanja[i] = imenabrojevi[imena[i]];
            }

            return 0;

        }

        /*private static int Zbroji(int broj)
       
        {
            if (broj == 1)
            {
                return 1;
            }
            return broj + Zbroji(broj - 1);
        }

        //100 + 99 + ...+1*/



    }
}
