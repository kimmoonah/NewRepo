using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213062023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();



            double deposito,cc, saldo = 0;

            while (true)

            {

                Console.WriteLine("\t\t\t\t\t---CAIXA ELETRÔNICO---");



                Console.WriteLine("Olá, bem-vindo ao caixa eletronico!");

                Console.ReadKey();



                Console.WriteLine("Qual operação deseja realizar?\n" +

                    "[1]SAQUE" +

                    "\n[2]DEPÓSITO" +

                    "\n[3]CONSULTA DE SALDO" +

                    "\n[4]SAIR");

                int opcao = int.Parse(Console.ReadLine());



                switch (opcao)

                {

                    case 1:

                        Console.WriteLine("Opção selecionada: \"SAQUE\"");

                        Console.Write("\nInforme o valor que deseja sacar: ");

                        double saque = double.Parse(Console.ReadLine());



                        if (saque <= 0 || saque > saldo)

                        {

                            Console.WriteLine("Operação inválida!");

                            Console.ReadKey();



                        }

                        else

                        {

                            Console.WriteLine("Saque concluído com sucesso!");

                            Console.ReadKey();

                        }

                        saldo -= saque;



                        Console.WriteLine("Realmente deseja finalizar esta opração?\n[1]SIM\n[2]NÂO");

                        int sairOuNao = int.Parse(Console.ReadLine());



                        switch (sairOuNao)

                        {

                            case 1:

                                Console.WriteLine("SAINDO...");

                                Environment.Exit(0);

                                break;

                            case 2:

                                Console.WriteLine("VOLTANDO AO INÍCIO...");

                                break;

                        }

                        break;

                    case 2:

                        Console.WriteLine("Opção selecionada: \"DEPÓSITO\"");

                        Console.Write("\nInforme o valor que deseja depositar: ");

                        deposito = double.Parse(Console.ReadLine());

                        saldo += deposito;



                        Console.WriteLine("Realmente deseja finalizar esta opração?\n[1]SIM\n[2]NÂO");

                        int yoN = int.Parse(Console.ReadLine());



                        switch (yoN)

                        {

                            case 1:

                                Console.WriteLine("SAINDO...");

                                Environment.Exit(0);

                                break;

                            case 2:

                                Console.WriteLine("VOLTANDO AO INÍCIO...");



                                break;



                        }

                        break;

                    case 3:

                        Console.WriteLine("Opção selecionada: \"CONSULTA DE SALDO\"");

                        Console.WriteLine($"Seu saldo é: {saldo}");

                        Console.ReadKey();



                        Console.WriteLine("Realmente deseja finalizar esta opração?\n[1]SIM\n[2]NÂO");

                        int sON = int.Parse(Console.ReadLine());



                        switch (sON)

                        {

                            case 1:

                                Console.WriteLine("SAINDO...");

                                Environment.Exit(0);

                                break;

                            case 2:

                                Console.WriteLine("VOLTANDO AO INÍCIO...");

                                break;

                        }

                        break;

                    case 4:

                        Console.WriteLine("SAINDO...");

                        Environment.Exit(0);

                        break;

                    default:

                        Console.WriteLine("Operação Invalida");

                        break;
                }
            }
        }
    }
}

