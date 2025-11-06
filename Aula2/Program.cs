using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string apelido;

            Console.WriteLine("Qual é o teu nome?");

            nome = Console.ReadLine();

            Console.WriteLine("Qual é o teu apelido?");

            apelido = Console.ReadLine();


            Console.WriteLine($"Olá {nome} {apelido}, muito gosto em conhecê-lo.");
        }
    }
}
