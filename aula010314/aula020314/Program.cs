using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula020314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("\t\t Insira três números");
            Console.WriteLine("Número 1: ");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Número 3: ");
            num3 = Convert.ToInt16(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"O número {num1} é o maior");
            }
            else if (num2 > num1 && num1 > num3)
            {
                Console.WriteLine($"O número {num2} é o maior");
            }
            else
            {
                Console.WriteLine($"O número {num3} é o maior");
            }
            Console.ReadKey();
        }
    }
}
