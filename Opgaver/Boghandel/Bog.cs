using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Boghandel
{
    internal class Bog
    {
        public string Titel {  get; set; }
        public string Forfatter { get; set; }
        public int AntalSider { get; set; }
        public int Nr {  get; set; }
        public Bog(string titel, string forfatter, int antalSider, int nr) { 
        Titel = titel;
        Forfatter = forfatter;
        AntalSider = antalSider;
        Nr = nr;
        }

    }
}
