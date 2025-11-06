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
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual é o seu apelido (sobrenome)? ");
            string apelido = Console.ReadLine();
            Console.WriteLine($"O seu nome completo é {nome} {apelido}.");



            string nome2, sobrenome;

            Console.WriteLine("Informe o seu primeiro nome");
            nome2 = Console.ReadLine();
            Console.WriteLine("Informe o seu sobrenome");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Bem vindo " + nome2 + " " + sobrenome);
            Console.WriteLine("Bem vindo {0} {1}", nome2, sobrenome);
            Console.WriteLine($"Bem vindo {nome2} {sobrenome}");


            string nome3;
            string apelido1;

            Console.WriteLine("Qual é o teu nome?");
            nome3 = Console.ReadLine();
    
            Console.WriteLine("Qual é o teu apelido?");
            apelido1 = Console.ReadLine();

            Console.WriteLine($"Olá {nome3} {apelido1}, muito gosto em conhecê-lo!");
            
        }
    }
}
