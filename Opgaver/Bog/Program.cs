using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Bog
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            string titel, forfatter, isbnnummer;
            Console.Write("Indtast titel på bogen: ");
            titel = Console.ReadLine();
            Console.Write("Indtast forfatter til bogen: ");
            forfatter = Console.ReadLine();
            Console.Write("Indtast isbnnummeret på bogen: ");
            isbnnummer = Console.ReadLine();
            Bog bog = new Bog(titel, forfatter, isbnnummer);
            Console.WriteLine(bog.titel + " " + bog.forfatter + " " + bog.isbnnummer);
        }
    }
}
