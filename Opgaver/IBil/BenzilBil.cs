using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.IBil
{
    public class BenzilBil : IBil
    {
        public string Farve {  get; set; }
        public int Km { get; private set; }
        public BenzilBil(int k) { 
        Km = k;
        }
        public void UdskrivBil()
        {
            Console.WriteLine($"BenzilBil ~ Farve: {Farve} ~ Km: {Km}");
        }
    }
}
