using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsiusFahrenheit270423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f1, f2, decremento, cel;
            Console.WriteLine("\t\t---Conversão Celsius-Fahrenheit---");

            Console.WriteLine("\nInsira o grau mínimo em Fahrenheit: ");
            f1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o grau máximo em Fahrenheit: ");
            f2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da escala: ");
            decremento = int.Parse(Console.ReadLine());

            for (; f2 >= f1; f1 = f1 - decremento)
            {
                cel = 5 * (f2 - 32) / 9;
                Console.WriteLine(cel);

            }
            Console.ReadKey();
        }
    }
}
