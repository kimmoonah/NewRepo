using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataNasc160523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t---DATA DE NASC. + IDADE---");

            DateTime now = DateTime.Now;

            Console.Write("Insira sua data de nascimento: ");
            DateTime dtNasc = DateTime.Parse(Console.ReadLine());
            Console.Clear();

            TimeSpan idade = now - dtNasc;
            int anoIdade = idade.Days;
            int anos = anoIdade / 365;
            Console.WriteLine($"Idade: {anos} anos");
            Console.ReadKey();

        }
    }
}
