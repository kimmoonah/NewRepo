using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci270423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---LER NÚMERO E ESCREVE NOME---");
            Console.Write("\nInsira um nome: ");
            string nome = Console.ReadLine();
            int length = (nome.Trim()).Length;

            while (length > 0)
            {
                Console.WriteLine(nome);
                length--;
                
            }
            Console.ReadKey();
        }
    }
}
