using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula030314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double n1, n2, n3, n4, med;

            Console.WriteLine("\t\tInsira o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\t\t---NOTAS---");
            Console.WriteLine("1° Bimestre:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2° Bimestre:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("3° Bimestre:");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("4° Bimestre:");
            n4 = double.Parse(Console.ReadLine());

            med = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine($"A média de {nome} é {med}");
            Console.ReadKey();
            Console.Clear();

            if(med >= 6.0)
            {
                Console.WriteLine($"Aluno(a) {nome} aprovado(a)");
            }
            else
            {
                Console.WriteLine($"Aluno(a) {nome} reprovado(a)");
            }
            Console.ReadKey();

        }
    }
}
