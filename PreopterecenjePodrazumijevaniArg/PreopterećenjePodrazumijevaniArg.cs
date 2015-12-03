using System;

namespace Vsite.CSharp
{
    class Program
    {

        public static int Zbroji(int x = 3, int y = 4) 
        {
            return x + y;
        }

        static int Zbroji(int x)
        {
            return x + 1;
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(Zbroji(5, 6));
            Console.WriteLine(Zbroji(5));
            Console.WriteLine(Zbroji());

            Console.ReadKey();
        }
    }
}
