

namespace Ucenje
{
    internal class E12Z1
    {

        // Program za dva unesena broja ispisuje njihov zbroj

        public static void Izvedi()
        {
            //Console.WriteLine("E12Z");

            int pb = E12Metode.UcitajCijeliBroj("Unesi prvi broj: ");
            int db = E12Metode.UcitajCijeliBroj("Unesi drugi broj:");

            Console.WriteLine("{0} + {1} = {2}", pb, db, pb + db);
        }

    }


    
}
