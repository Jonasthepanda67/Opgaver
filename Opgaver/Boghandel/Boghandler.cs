using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Boghandel
{
    class Boghandler
    {
        public string Sælg(string titel, string forfatter, int antalSider, int nr) {
            Bog bog = new Bog(titel, forfatter, antalSider, nr);
            return $"Bognummer: {nr} Titel: {titel} Forfatter: {forfatter} AntalSider: {antalSider}";
        }
    }
}
