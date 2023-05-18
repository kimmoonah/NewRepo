
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile250423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("\t\t---Ajuda nas compras---");

            Console.WriteLine("\nInforme o valor disponível: ");
            double saldo = double.Parse(Console.ReadLine());

            double compra = 0;
            int cont = 0;
            double somaCompras = 0;
            bool podeComprar = true;

            do
            {
                Console.Write("\nValor da compra: ");
                compra = double.Parse(Console.ReadLine());

                if (compra > 0)
                {
                    if(compra <= saldo)
                    {
                        saldo = saldo - compra;
                        somaCompras = somaCompras + compra;
                        cont++;
                        Console.WriteLine("\nCompra autorizada!" +
                            "\n\nSaldo disponível: {0:c2}", saldo);
                           
                    }
                    else
                    {
                        podeComprar = false;
                        Console.WriteLine("\nVocê não possui saldo suficiente para realizar essa compra!");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido!");

                }
            }
            while (podeComprar);
            Console.Clear();
            Console.WriteLine("\t\t---Resultado das compras---");
            Console.WriteLine($"\nNúmero de compras: {cont}" + $"\nTotal gasto: {somaCompras:c2}" 
                + $"\nSaldo restante: {saldo:c2}");
            Console.ReadKey();
        }
    }
}
