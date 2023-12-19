using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.IBil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBil benzinBil = new BenzilBil(200000) { Farve = "Pink"};
            IBil dieselBil = new DieselBil(140000) { Farve = "Brun" };

            benzinBil.UdskrivBil();
            dieselBil.UdskrivBil();
        }
    }
}
