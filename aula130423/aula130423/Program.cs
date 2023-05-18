using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula130423
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---MÉDIA ALUNO E TURMA---");
            Console.Write("\nQuantos alunos tem na turma? ");
            int qtdAlunos = int.Parse(Console.ReadLine());
            double n1, n2, n3, n4, nTurma = 0, nTotal, aFinal;
            aFinal = qtdAlunos;

            while(aFinal != 0)
            {
                Console.Write("\nInsira a nota do 1° bimestre: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("\nInsira a nota do 2° bimestre: ");
                n2 = double.Parse(Console.ReadLine());
                Console.Write("\nInsira a nota do 3° bimestre: ");
                n3 = double.Parse(Console.ReadLine());
                Console.Write("\nInsira a nota do 4° bimestre: ");
                n4 = double.Parse(Console.ReadLine());
                double mediaAluno = (n1 + n2 + n3 + n4) / 4;
                Console.WriteLine("\nA média do aluno é: " + mediaAluno);
                nTurma = nTurma + mediaAluno;
                aFinal--;
            }
            Console.Clear();
            nTotal = nTurma / qtdAlunos;
            Console.WriteLine("A média da turma é: " + nTotal);
            Console.ReadKey();
        }
    }
}
