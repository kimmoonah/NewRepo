using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula060316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Calcula o IMC---");
            double alt, peso, imc;

            Console.WriteLine("\n Informe seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Informe sua altura: ");
            alt = double.Parse(Console.ReadLine());
        }
    }
}
