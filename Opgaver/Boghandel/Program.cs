using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Boghandel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Bog> forlagBog = new List<Bog>();
            Forlag forlag = new Forlag();
            do
            {
                string titel;
                string forfatter;
                int antalSider, nr;
                /*double pris;
                string forNavn, efterNavn, fuldeNavn, adresse, prisen;*/
                Boghandler boghandler = new Boghandler();


                /*Console.Write("Indtast Fornavn: ");
                forNavn = Console.ReadLine();
                Console.Write("Indtast Efternavn: ");
                efterNavn = Console.ReadLine();
                fuldeNavn = forNavn + efterNavn;
                Console.Write("Indtast Adresse: ");
                adresse = Console.ReadLine();
                Console.Write("Indtast en pris: ");
                prisen = Console.ReadLine();
                double.TryParse(prisen, out pris);

                Console.Clear();
                Console.WriteLine($"{str} - Pris {pris}");*/
                Console.Write("\nIndtast titel på bogen: ");
                titel = Console.ReadLine();
                Console.Write("Indtast forfatter på bogen: ");
                forfatter = Console.ReadLine();
                Console.Write("Indtast antal sider på bogen: ");
                antalSider = int.Parse(Console.ReadLine());

                if (forlagBog.Count() == 0)
                {
                    nr = 1;
                }
                else
                {
                    nr = forlagBog.Count() + 1;
                }

                string str = boghandler.Sælg(titel, forfatter, antalSider, nr);
                forlagBog.Add(forlag.Modtag(titel, forfatter, antalSider, nr));
                Console.WriteLine("\n" + str);
            } while (true);
        }
    }
}
