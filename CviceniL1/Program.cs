using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniL1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, jak se jmenuješ?");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Jaký jsi?");
            string vlastnost = Console.ReadLine();
            vlastnost = vlastnost.ToLower();
            Console.WriteLine(jmeno + " je " + vlastnost + ".");
            Console.ReadKey();
        }
    }
}
