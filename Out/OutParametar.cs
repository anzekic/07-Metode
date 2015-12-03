﻿using System;

namespace Vsite.CSharp
{
    // Primjer out parametra

    class OutParametar
    {
        static void InicijalizirajBrojNaDeset(out int x)
        {
            x = 10;
        }

        static void InicijalizirajBrojNaDvaDeset(int x)
        {
            x = 20;
        }

        static void Main(string[] args)
        {
            int x;
            InicijalizirajBrojNaDeset(out x);
            InicijalizirajBrojNaDvaDeset(x);
            Console.WriteLine(x);
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
