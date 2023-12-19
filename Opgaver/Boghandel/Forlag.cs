using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Boghandel
{
    internal class Forlag
    {
        public Bog Modtag(string titel, string forfatter, int antalSider, int nr)
        {
            Bog bog = new Bog(titel, forfatter, antalSider, nr);
            return bog;
        }
    }
}
