using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.NedarvPerson
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Person pObjekt = new Person("Peter", "Madsen", 28);
            Elev eObjekt = new Elev("Hans", "Erik", 26, 2);

            //Udskriver person og elev objekterne ved at bruge udskriv metoderne
            Console.WriteLine("\nUdskriver ved at bruge Person objektet");
            pObjekt.Udskriv();
            Console.WriteLine("\nUdskriver ved at bruge Elev objektet");
            eObjekt.Udskriv();

            //Person objektet's referencevariabel peger på elev objektet
            pObjekt = eObjekt;

            //Udskriver ved at bruge udskriv metoden nu hvor person objektets referencevariabel er ændret
            Console.WriteLine("\nUdskriver person objektet som peger på elev objektet");
            pObjekt.Udskriv();

            List<Person> pList = new List<Person> {
                new Person("Adolf", "schnitsler", 54),
                new Elev("Fin", "Holger", 84, 3)
            };

            Console.WriteLine("\nUdskriver alle objekter i listen");
            foreach (Person pobjekt in pList)
            {
                pobjekt.Udskriv();
            }
        }
    }
}
