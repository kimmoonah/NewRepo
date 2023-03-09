using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, phone, adress;
            Console.WriteLine("\tPERSONAL DATA");
            Console.ReadKey();
            Console.WriteLine("\nType your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Type your number phone: ");
            phone = Console.ReadLine();
            Console.WriteLine("Type your e-mail adress: ");
            adress = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Following your data:\n Name: {name};\n Phone: {phone};\n Adress: {adress}.");
            Console.ReadKey();
        }
    }
}

