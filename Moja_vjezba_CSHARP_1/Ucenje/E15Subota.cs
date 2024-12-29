

namespace Ucenje
{
    internal class E15Subota
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E15Subota");

            PrimjerTryCatch();
        }

        private static void PrimjerTryCatch()
        {



            try
            {
                int.Parse("Osijek");
            }
            catch
            {
                Console.WriteLine("Žao nam je zbog greške");

            }


            bool vrijednost = false;

            Console.WriteLine("Da li si zaposlen/a? (Upiši DA ili bilo što za NE)");
            if (Console.ReadLine().Trim().ToUpper() == "DA")
            {
                vrijednost = true;
            }


            Console.WriteLine(vrijednost);

            Console.WriteLine(E12Metode.UcitajBool("Da li si zaposlen/a? (Upiši DA ili bilo što za NE)", "DA"));

            Console.WriteLine(E12Metode.UcitajBool("Jutros sam pojeo tri sendviča (Istina/Laž)", "Istina"));

        }

    }
}
