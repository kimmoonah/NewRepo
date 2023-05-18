using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nvCand1 = 0, nvCand2 = 0, nvCand3 = 0, nvBrancos = 0, nvNulos = 0, nEleitores = 0, op;
            string resposta = "SIM";

            do
            {
                Console.WriteLine("\n\t\tQual a malhor séri de todos os tempos?");
                Console.WriteLine("\n\t[1]The big bang theory\n\t[2]game of thrones\n\t[3]the glory\n\t[4]outras\n\t[5]não sei!");
                Console.WriteLine("informe a sua opção");
                op =

            switch op
            {
                    case 1:

                }
                Console.WriteLine("\nvotos realizados com sucesso");
                Console.WriteLine("\ndeseja registras outro voto?");
                Console.WriteLine("");
                resposta = Console.ReadLine().ToUpper;
            }
            while (resposta == "SIM" || resposta == "S");

            nEleitores = nvCand1 + nvCand2 + nvCand3 + nvBrancos + nvNulos;
            Console.WriteLine("\n\t\t---Resultado da votção---");
            Console.WriteLine("\nNúmero de votos: " + nEleitores);
            Console.WriteLine("the big bang theory: " + nvCand1);
            Console.WriteLine("the big bang theory: " + nvCand1);
            Console.WriteLine("the big bang theory: " + nvCand1);


        }
    }
}
