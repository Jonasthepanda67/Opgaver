using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Regnemaskine
{
    delegate int CalculatorDelegate(int a, int b);
    public class Program
    {
        static void Main(string[] args)
        {
            CalculatorDelegate cD = Add;
            int valg, a, b, resultat;

            Console.WriteLine("\nVælg en operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.Write("Indtast valg her: ");

            valg = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (valg)
            {
                case 1:
                    cD = Add;
                    break;
                case 2:
                    cD = Sub;
                    break;
                default:
                    break;
            }
            Console.Write("Indtast første heltal: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Indtast andet heltal: ");
            b = int.Parse(Console.ReadLine());

            resultat = cD(a, b);
            Console.Clear();
            Console.WriteLine($"\nResultatet er: {resultat}");
        }

        static int Add(int a, int b) {  return a + b; }
        static int Sub(int a, int b) {  return a - b; }
    }
}
