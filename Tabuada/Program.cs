using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    // Dado um determinado número pelo utilizador, efetue o cálculo da tabuada desse número (1 – 10)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada de um número!");
            Console.Write("\nIntroduza um número inteiro: ");
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("\nValor inválido! \nIntroduza um número inteiro: ");
            }

            Console.WriteLine($"\nTabuada do número {numero}:\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

        }
    }
}
