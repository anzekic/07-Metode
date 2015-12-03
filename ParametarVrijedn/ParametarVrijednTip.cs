using System;

namespace Vsite.CSharp
{
    // primjer kako se parametri prenose po vrijednosti
    class ParametarVrijednTip
    {
        static void Uvećaj(int n)
        {
            n += 1;
            Console.WriteLine("U metodi Uvećaj: {0}", n);
        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Prije metode Uvećaj: {0}", n);

            Uvećaj(n);

            Console.WriteLine("Nakon metode Uvećaj: {0}", n);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
