using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Den_lille_tabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < tal.Length; i++)
            {
                Console.Write(tal[i]);
            }
        }
    }
}
