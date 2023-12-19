using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Struct
{
    public struct Bil
    {
        public string Farve;
        public int Km;
        public int Hk;

        public Bil(string f, int k, int h)
        {
            Farve = f;
            Km = k;
            Hk = h;
        }

        public void Udskriv()
        {
            Console.WriteLine($"Farve {Farve} ~ Kilometer: {Km} ~ Hestekræfter: {Hk}");
        }
    }
}
