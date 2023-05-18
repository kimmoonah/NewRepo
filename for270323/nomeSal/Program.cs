using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomeSal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---NOME E CÁLCULO DE IMPOSTO---");
            int qtdPessoas = 10;

            while(qtdPessoas > 0)
            {
                Console.Write("\nInsira seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("\nInsira seu salário: ");
                double sal = double.Parse(Console.ReadLine());
                qtdPessoas--;

                if (sal < 1000)
                {
                    Console.WriteLine($"\n{nome} está isento de impostos!");
                }
                else if(sal < 1500)
                {
                    sal = sal * 0.075;
                    Console.WriteLine($"{nome} tem que pagar {sal} de imposto de renda.");
                }
                else
                {

                }
            }
        }
    }
}
