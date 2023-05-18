using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idadeCompleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t---DATA DE NASC. + IDADE COMPLETA---");

            DateTime now = DateTime.Now;

            Console.Write("Insira sua data de nascimento: ");
            DateTime dtNasc = DateTime.Parse(Console.ReadLine());
            Console.Clear();

            TimeSpan idade = now - dtNasc;

            int anos = idade.Days / 365;
            int meses = (idade.Days % 365) / 30;
            int dias = (idade.Days % 365) % 30;

            Console.WriteLine($"Você tem {anos} anos, {meses} meses e {dias} dias.");
            Console.ReadKey();
        }
    }
}
