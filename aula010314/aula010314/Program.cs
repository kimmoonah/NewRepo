using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula010314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tverifica se um numeor é par ou impar");
            Console.Write("\nInforme o número.\n");
            int num = int.Parse(Console.ReadLine());

            Console.Clear();
            if(num % 2 == 0)
            {
                Console.WriteLine($"O número {num} é par");
            }
            else
            {
                Console.WriteLine($"O número {num} é impar");
            }
            Console.ReadKey();
        }
    }
}
