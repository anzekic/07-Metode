using System;

namespace Vsite.CSharp
{
    // Ilustracija korištenja ref parametra vrijednosnog tipa

    class RefParametar
    {
        static void DodajDeset(ref int x)
        {
            x += 10;
            Console.WriteLine("Unutar metode DodajDeset: {0}", x);
        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Prije metode DodajDeset: {0}", n);

            DodajDeset(ref n);

            Console.WriteLine("Nakon metode DodajDeset: {0}", n);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
