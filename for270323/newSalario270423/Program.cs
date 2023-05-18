using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSalario270423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            double salario, reajuste, novoSalario;

            for (int i = 0; i < 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Clear();

                Console.WriteLine("\t\t---Calcula Novo Salário---");

                Console.Write("\n Informe salário: ");
                salario = double.Parse(Console.ReadLine());

                if (salario < 1000)
                {
                    reajuste = salario * 0.55;
                    novoSalario = salario + reajuste;
                    Console.WriteLine("\n\t\t---Reajuste---");
                    Console.WriteLine("\nSalário atual: {0:c2}", salario);
                    Console.WriteLine("Reajuste: {0:c2}", reajuste);
                    Console.WriteLine("Novo Salário: {0:c2}", novoSalario);
                }
                else if (salario < 2500)
                {
                    reajuste = salario * 0.30;
                    novoSalario = salario + reajuste;
                    Console.WriteLine("\n\t\t---Reajuste---");
                    Console.WriteLine("\nSalário atual: {0:c2}", salario);
                    Console.WriteLine("Reajuste: {0:c2}", reajuste);
                    Console.WriteLine("Novo Salário: {0:c2}", novoSalario);
                }
                else
                {
                    reajuste = salario * 0.20;
                    novoSalario = salario + reajuste;
                    Console.WriteLine("\n\t\t---Reajuste---");
                    Console.WriteLine("\nSalário atual: {0:c2}", salario);
                    Console.WriteLine("Reajuste: {0:c2}", reajuste);
                    Console.WriteLine("Novo Salário: {0:c2}", novoSalario);
                }
                Console.ReadKey();
            }
        }
    }
}
