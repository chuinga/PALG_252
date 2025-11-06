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

            /* Este é um comentário
               de váras linhas */

            // C# é case sensitive - Miguel é diferente de miguel

            Console.WriteLine("Olá Mundo!"); // WriteLine quebra a linha
            Console.Write("Olá Mundo do "); // Write não quebra a linha)
            Console.Write("Miguel"); // Write não quebra a linha
            Console.Write("\nMiguel\tViaja\npelo Mundo"); // \n quebra a linha, \t adiciona um tab

            Console.ReadKey(); // Mantém a janela aberta até que uma tecla seja pressionada

            // Variáveis para armazenar dados do utilizador
            // Variáveis de texto - strings - armazenam texto e são rodeadas por aspas duplas
            // char - apenas contém um único caracter

            // <tipo de variável> <nome da variável> = <valor>;
            string nome = "Jarbas";
            string utilizador;

            Console.WriteLine("Qual é o teu nome?");
            // Ler e guardar o nome do utilizador
            utilizador = Console.ReadLine(); // Lê uma linha de texto do utilizador

            Console.WriteLine("Olá " + utilizador + ", o meu nome é " + nome + "."); // Concatenação de strings

            Console.WriteLine($"O meu nome é {nome} e o teu nome é {utilizador}."); // Interpolação de strings
        }
    }
}
