using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Bog
{
    internal class Bog
    {
        public string titel { get; set; }
        public string forfatter { get; set; }
        public string isbnnummer { get; set; }
        public Bog(string t, string f, string i)
        {
            titel = t;
            forfatter = f;
            isbnnummer = i;
        }
    }
}
