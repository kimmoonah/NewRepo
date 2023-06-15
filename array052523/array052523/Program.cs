


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array052523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um array para guardar o nome de cinco pessoas. O
            programa deve solicitar que usuário informe os nomes e
            em seguida imprimi-los na tela*/

            Console.WriteLine("\t\t---ARRAY GUARDA E IMPRIME---");

            int nNome = 1;
            string[] nome = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {nNome}° nome: ");
                nome[i] = Console.ReadLine();

                nNome++;  
            }
            Console.WriteLine("Nomezinhos: ");
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }
            Console.ReadKey();
        }
    }
}
