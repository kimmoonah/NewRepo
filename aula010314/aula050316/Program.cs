using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula050316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Reajuste salarial---");
            Console.Write("\n Insira o valor do seu salário para cálcular o reajuste: ");
            double sal = double.Parse(Console.ReadLine());

            if (sal <= 1500)
            {
                sal = sal + sal * 0.23;
                Console.WriteLine($"\nSeu novo salário será de {sal.ToString("c2")}");
            }
            else
            {
                sal = sal + sal * 0.18;
                Console.WriteLine($"\nSeu novo salário será de {sal.ToString("c2")}");
            }
            Console.ReadKey();
        }
    }
}
