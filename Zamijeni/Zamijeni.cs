using System;

namespace Vsite.CSharp
{
    // Primjer ref parametra referentnog tipa
    class Zamijeni
    {

        static void ZamijeniString(ref string s1, ref string s2)
        {
            string temp = s2;
            s2 = s1;
            s1 = temp;

            Console.WriteLine("Prije izlaska iz metode Zamijeni(string, string)");
            Console.WriteLine("prvi = '{0}'", s1);
            Console.WriteLine("drugi = '{0}'", s2);
        }

        static void ZamijeniObjekt(ref object o1, ref object o2)
        {
            Object temp = o2;
            o2 = o1;
            o1 = temp;
        }

        static void Main(string[] args)
        {
            string prvi = "prvi";
            string drugi = "drugi";

            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            ZamijeniString(ref prvi, ref drugi);

            Console.WriteLine("Nakon metode 'ZamijeniString(string, string)'");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
            Console.WriteLine();

            object obj1 = (object)prvi;
            object obj2 = (object)prvi;

            ZamijeniObjekt(ref obj1, ref obj2);

            prvi = (string)obj1;
            drugi = (string)obj2;

            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
            Console.WriteLine();


            Console.WriteLine("Nakon metode 'Zamijeni<T>()'");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
