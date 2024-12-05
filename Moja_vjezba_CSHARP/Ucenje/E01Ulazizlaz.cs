namespace Ucenje
{
    internal class E01Ulazizlaz
    {

        public static void Izvedi()
        {
            // Ovo je zlaz
            Console.Write("Unesi svoje ime: "); 


            // Ulaz podataka u program
            string Ime = Console.ReadLine();

            Console.WriteLine("Unijeli ste " + Ime);

            // formatirani način ispisa
            Console.WriteLine("Unijeli ste {0}. Bravo", Ime);


        }



    }
}
