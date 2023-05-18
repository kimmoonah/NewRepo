using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for270323
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Número: " + i);
            }
            Console.ReadKey();

            for (int i = 1, j = 2; i % 2 != 0 || j % 2 == 0; i += j, j += i)
            {
                Console.WriteLine($"i vale: {i};" + $"\nj vale: {j}.");
            }
            Console.ReadKey();
        }
    }
}
