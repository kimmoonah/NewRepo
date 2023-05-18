using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaSwitch010321
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Aumento de salarial---");
            Console.WriteLine("Cargos: \n\t[1] Gerente \n\t[2] Engenheiro \n\t[3] Técnico");

            Console.Write("\nInforme seu cargo: ");
            int cargo = int.Parse(Console.ReadLine());

            Console.Write("Informe seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            double newsal = 0;

            switch (cargo)
            {
                case 1:
                    newsal = salario + (salario * 0.1);
                    break;
                case 2:
                    newsal = salario + (salario * 0.2);
                    break;
                case 3:
                    newsal = salario + (salario * 0.3);
                    break;
                default:
                    newsal = salario + (salario * 0.4);
                    break;
            }
            Console.WriteLine("\nSalário antigo: {0:c2}" + 
                "\nNovo salário: {1:c2}" + 
                "\nReajuste: {2:c2}", salario, newsal, newsal-salario);

            Console.ReadKey();
        }
    }
}
