using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Baggrundsfarve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread timer = new Thread(Timer);
            timer.Start();

            string msg = "";
            int bredde = Console.WindowWidth;
            int højde = Console.WindowHeight;
            int x = (bredde - msg.Length) / 2;
            int y = højde / 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
            Console.ReadKey();

            timer.Abort();
        }
        static void Timer()
        {
            while (true) {
                SkiftFarve();
                Thread.Sleep(5000);
            }
        }
        static void SkiftFarve()
        {
            string msg = "";
            int bredde = Console.WindowWidth;
            int højde = Console.WindowHeight;
            int x = (bredde - msg.Length) / 2;
            int y = højde / 2;
            Random rnd = new Random();
            ConsoleColor[] farver = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.BackgroundColor = farver[rnd.Next(farver.Length)];

            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
    }
}
