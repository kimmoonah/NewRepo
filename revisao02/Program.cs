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
            Console.WriteLine("Insira um valor em graus Celcius.");
            cels = double.Parse(Console.ReadLine());

            fahr = (cels * 9 / 5) + 32;

            Console.Clear();
            Console.WriteLine($"{cels}°C equivalem á {fahr}°F");
            Console.ReadKey();
        }
    }
}
