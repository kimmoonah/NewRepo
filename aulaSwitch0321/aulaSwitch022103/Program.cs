using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaSwitch022103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Nota de Aluno---");
            Console.WriteLine("\nInsira o nome do/a aluno/a: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\nInsira a nota do 1° bimestre: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 2° bimestre: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 3° bimestre: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira a nota do 4° bimestre: ");
            int n4 = int.Parse(Console.ReadLine());

            int media = (n1 + n2 + n3 + n4) / 4;

            if(media >= 90)
            {
                media = 'A';
            }
            else if(media >= 80)
            {
                media = 'B';
            }
            else if(media >= 60)
            {
                media = 'C';
            }
            else if(media >= 40)
            {
                media = 'D';
            }
            else if(media >= 20)
            {
                media = 'E';
            }
            else
            {
                
            }
        }
    }
}
