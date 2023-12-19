using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Enumeration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Farver valgtFarve = Farver.Grøn;

            UdskrivFarve(valgtFarve);
        }
        static void UdskrivFarve(Farver farve)
        {
            Console.WriteLine($"Den valgte farve er: {farve}");
        }
    }
}
