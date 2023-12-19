using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.IBil
{
    public class DieselBil : IBil
    {
        public string Farve {  get; set; }
        public int Km { get; private set; }
        public DieselBil(int k) {
        Km = k;
        }
        public void UdskrivBil()
        {
            Console.WriteLine($"DieselBil ~ Farve: {Farve} ~ Km: {Km}");
        }
    }
}
