using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCasting
{
    class Program
    {
        static int a;
        static byte b = 2;
        static byte c = 4;
        static double d = 47.11;
        static double k = 426.66;

        static void Main(string[] args)
        {
            a = b + c; //byte in int geht implizit
            Console.WriteLine(a);
            Console.ReadKey();

            //b = (2 * c); //byte nicht in int implizit, aus Operationen mit Byte wird automatisch int

            a = b * 2;
            Console.WriteLine(a);
            Console.ReadKey();

            // a = d; //double nicht implizit in int

            d = a; //int in double geht implizit
            Console.WriteLine(a);
            Console.ReadKey();

            int f = Convert.ToInt32(k); //Explizit double in int
            Console.WriteLine(f + " Kommastellen weg");
            Console.ReadKey();

            f++; //Postfix Inkrement
            Console.WriteLine(f + " +1");
            Console.ReadKey();

            f--; //Postfix Dekrement
            Console.WriteLine(f + " -1");
            Console.ReadKey();

            --f; //Präfix Dekrement
            Console.WriteLine(f + " -1");
            Console.ReadKey();

            ++f; //Präfix Inkrement
            Console.WriteLine(f + " +1");
            Console.ReadKey();
        }
    }
}