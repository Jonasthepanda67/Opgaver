using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Opgaver.Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            int id; string name; string valg, menuvalg;
            List<Car> cars = new List<Car>();
            do
            {
                Console.Clear();
                Garage garage = new Garage();
                Console.WriteLine("1: Tilføj Biler");
                Console.WriteLine("2: Find en bil");
                Console.WriteLine("3: Udlæs alle biler");
                Console.WriteLine("4: Fjern en bil");
                Console.WriteLine("5: Afslut");
                Console.Write("Indtast valg her: ");
                menuvalg = Console.ReadLine();
                Console.Clear();
                switch (menuvalg)
                {
                    case "1":
                        do
                        {
                            Console.Write("\nIndtast bilnavn: ");
                            name = Console.ReadLine();
                            Console.WriteLine(garage.TilføjBil(name, cars));
                            Console.Write("\nVil du tilføje endnu en bil? (j/n): ");
                            valg = Console.ReadLine();
                        } while (valg.ToLower() == "j" || valg.ToLower() == "ja");
                        break;
                    case "2":
                        Console.Write("\nIndtast BilId her: ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine(garage.FindBil(id, cars));
                        Console.WriteLine("\nTryk på en hvilken som helst knap for at fortsætte...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("\n" + garage.UdlæsBiler(cars));
                        Console.WriteLine("\nTryk på en hvilken som helst knap for at fortsætte...");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Write("\nIndtast BilId her: ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine(garage.FjernBil(id, cars));
                        Console.WriteLine("\nTryk på en hvilken som helst knap for at fortsætte...");
                        Console.ReadKey();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nDu har indtastet forkert prøv igen...");
                        Console.WriteLine("\nTryk på en hvilken som helst knap for at fortsætte...");
                        Console.ReadKey();
                        break;
                }
            } while (true);
        }
    }
}
