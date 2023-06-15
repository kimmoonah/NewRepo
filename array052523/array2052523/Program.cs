using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2052523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t---Array 5 Elementoss---");

            int[] var = new int[5];

            Console.Write("\nInforme 5 números num intervalo de 10 à 50:");
            Console.ReadKey();
            Console.Clear();

            int ordi = 1;
            for (int i = 0; i < var.Length; i++)
            {
                Console.WriteLine($"{ordi}° valor");
                var[i] = int.Parse(Console.ReadLine());

                ordi++;
                if (var[i] < 10 || var[i] > 50)
                {
                    Console.WriteLine("Valor inválido!\n\nTente novamente...");
                }

            }
            Console.WriteLine(var);
        }
    }
}
