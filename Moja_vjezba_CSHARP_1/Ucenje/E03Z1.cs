namespace Ucenje
{

    // Program od korisnika unosi dva cijela broja
    // Program ispisuje u novim redovima
    // 1. zbroj
    // .2 razlika drugog i prvog broja
    // 3. umnožak
    // 4. zbroj kvadrata prvog i drugog broja
    // 5. kvocijent prvog i drugog broja
    internal class E03Z1
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E03Z1");

            int i = 0, j = 0;

            Console.WriteLine("Unesi 1. cijeli broj: ");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 2. cijeli brij: ");
            j = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj: {0} ", i + j);

            Console.WriteLine("Razlika: {0} ", j - i);

            Console.WriteLine("Umnožak: {0} ", i * j);

            Console.WriteLine("Zbroj kvadrata 1. i 2. broja: {0} ", (i * i) + (j * j));

            Console.WriteLine("Kvocijent: {0} ", i / j);



        }

            

       



    }
}
