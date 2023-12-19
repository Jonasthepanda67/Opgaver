using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.NedarvPerson
{
    public class Elev : Person
    {
        public int KlasseNr {  get; set; }
        //Constructor ved brug af Base
        public Elev(string f, string e, int a, int k) : base(f, e, a)
        {
        KlasseNr = k;
        }
        public override void Udskriv()
        {
            Console.WriteLine($"Navn: {Navn} Alder: {Alder} KlasseNr: {KlasseNr}");
        }
    }
}
