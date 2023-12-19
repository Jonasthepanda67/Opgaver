using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Struct
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bil bil;
            bil.Farve = "Lilla";
            bil.Km = 80085;
            bil.Hk = 65;

            Bil bil2 = new Bil("Grøn", 55000, 80);

            Console.WriteLine("\nBil 1:");
            bil.Udskriv();

            Console.WriteLine("\nBil 2:");
            bil2.Udskriv();

            Bil bil3 = bil;

            bil.Farve = "Sort";

            Console.WriteLine("\nEfter ændring af bil 1's farve:");
            Console.WriteLine("Bil 1:");
            bil.Udskriv();

            Console.WriteLine("\nBil 3(Kopi af bil 1):");
            bil3.Udskriv();
        }
    }
}
