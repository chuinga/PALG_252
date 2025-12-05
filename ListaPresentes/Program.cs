using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPresentes
{
    internal class Program
    {
        // Guarde a lista de presentes de cada pessoa 
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> whislist = new Dictionary<string, List<string>>();

            whislist["Patrícia"] = new List<string>() { "Memória RAM", "Game Last Of Us", "A chave do Euromilhões correta", "Livro da Agatha Christie" };
            whislist["João"] = new List<string>() { "Consola", "Smartwatch" };

            Console.WriteLine("Lista de Presentes Pretendidos:");

            foreach (var item in whislist)
            {

                Console.WriteLine($"Whislist de {item.Key}");
                foreach (var desejo in item.Value)
                {
                    Console.WriteLine($" - {desejo}");
                }

                Console.WriteLine();
            }
        }
    }
}
