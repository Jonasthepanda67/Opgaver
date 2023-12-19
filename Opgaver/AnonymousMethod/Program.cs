using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opgaver.AnonymousMethod
{
    delegate int MyDelegate(int p, int q);
    
    class Program
    {
            static void Main()
            {
                MyDelegate arithMethod = (c, d) => c > d? c : d;

                Console.WriteLine("Det største af tallene er: {0}", arithMethod(8, 7));
            }

            /*static int Max(int c, int d)
            {
                if (c > d)
                    return c;
                else
                    return d;
            }*/
    }
}