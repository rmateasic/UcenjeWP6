

namespace Ucenje
{
    internal class E07Z1
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E07Z1");

            Console.WriteLine("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            
            if (broj % 2 == 0)
            {
                int suma = 0;
                for (int i = 0; i <= broj; i++)
                {
                    suma += i;
                }
                Console.WriteLine(suma);
            }
            else
            {
                for (int i = 0; i <= broj; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
           

        }


    }
}
