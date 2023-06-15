using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113062023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //correção do professor

            Console.WriteLine("ENFERMARIA");
            int[,] pulsos = new int[24, 4];

            for (int linha = 0; linha < 24; linha++)
            {
                Console.WriteLine("Leitura de pulsações da {0}° hora", linha+1);
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.WriteLine("paciente {0}: ", coluna+1);
                    pulsos[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
