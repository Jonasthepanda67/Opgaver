using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.NedarvPerson
{
    public class Person
    {
        private string Fornavn;
        private string Efternavn;
        public string Navn => $"{Fornavn} {Efternavn}";
        public int Alder { get; set; }
        //Constructor
        public Person(string f, string e, int a) {
        Fornavn = f;
        Efternavn = e;
        Alder = a;
        }
        //Udskriv metode
        public virtual void Udskriv()
        {
            Console.WriteLine($"Navn: {Navn} Alder: {Alder}");
        }
    }
}
