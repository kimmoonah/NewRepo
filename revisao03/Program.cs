using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cels, fahr;
            Console.WriteLine("Insira um valor em Fahrenheit.");
            fahr = double.Parse(Console.ReadLine());

            cels = (fahr - 32) * 5 / 9;

            Console.Clear();
            Console.WriteLine($"{fahr}°F equivalem á {cels}°C");
            Console.ReadKey();
        }
    }
}
