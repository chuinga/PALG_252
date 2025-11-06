using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Este é um comentário de uma linha
            /*
                Este 
            é um comentário
            de várias 
            linhas
            */

            // C# Case sensitive - Patricia <> patricia

            Console.WriteLine("Olá Mundo!");
            Console.Write("Olá Mundo!");
            Console.Write("Patrícia");
            Console.Write("\nPatrícia\tRocha\nSó porque sim!");

            // \t - tabulação
            // \n - quebra de linha

            //Console.ReadKey(); //Aguarda que uma tecla seja pressionada

            // Variáveis para armazenar dados do utilizador
            // Variáveis de texto - strings - armazenam texto e são rodeadas por aspas duplas
            // char - apenas contém um único caracter

            // <tipode variável> <nome da variável> = <valor>;
            string nome = "Maria";
            string utilizador, sobrenome="Rocha";

            Console.WriteLine("Qual é o teu nome?");
            // Ler e Guardar o valor do nome do utilizador
            utilizador = Console.ReadLine(); // Lê uma linha de texto de utilizador

            //Exibir o nome do utilizador e uma mensagem
            Console.WriteLine("Olá " + utilizador + "   " + "    " + sobrenome); //Concatenação de uma string utilizador e um literal de texto Olá
            Console.WriteLine($"O meu nome é {utilizador}.");
            Console.WriteLine("O meu nome é {0} {1}.", utilizador, sobrenome);
            
            Console.ReadKey();
        }
    }
}
