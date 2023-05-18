using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula040314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n1, n2;
            Console.WriteLine("\t\t ---Insira dois nomes---");
            Console.ReadKey();
            Console.WriteLine("Nome 1:\n");
            n1 = Console.ReadLine();
            Console.WriteLine("Nome 2:\n");
            n2 = Console.ReadLine();
            int n1len = n1.Length;
            int n2len = n2.Length;

            Console.WriteLine($"\"{n1}\" tem {n1len} letras e \"{n2}\" tem {n2len} letras");
            Console.WriteLine("Press any key to see wich is te biggest...");
            Console.ReadKey();
            Console.Clear();

            if (n1len > n2len)
            {
                Console.WriteLine($"O nome {n1} é maior");
            }
            else if(n1len == n2len)
            {
                Console.WriteLine("Os nomes tem o mesmo tamanho");
            }
            else
            {
                Console.WriteLine($"O nome {n2} é maior");
            }
            Console.ReadKey();
        }
    }
}
