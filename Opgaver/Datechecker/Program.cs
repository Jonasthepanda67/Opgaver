using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Datechecker
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string dato;
            Console.Write("Indtast en dato Eksempel(20/04/2023): ");
            dato = Console.ReadLine();
            Console.WriteLine(CheckDato(dato));
        }
        static string CheckDato(string dato)
        {
            DateTime Dato;string msg = "";
            Console.Clear();
            try
            {
                Dato = Convert.ToDateTime(dato);
                Console.WriteLine("\nDatoen er konverteret korrekt godt klaret!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nDer er fejl i den indtastet dato da den ikke kunne konverteres til DateTime...\n{ex.Message}");
                throw;
            }
            if (Dato < DateTime.Now.Date)
            {
                msg = "\nDu har indtastet en dato før dags dato godt klaret!";
            }
            else
            {
                Exception ex = new Exception($"{Dato.ToShortDateString()} is greater than {DateTime.Now.ToShortDateString()}");
                msg = $"\nDen indtastet dato er forkert da den er efter dags dato...\n{ex.Message}";
            }
            return msg;
        }
    }
}
