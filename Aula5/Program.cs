using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ciclos de Repetição – Loops
            // While
            // while (condition)
            // {
            //     statements
            // }

            int i = 0;

            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Do While – Assegura que o bloco de código do loop seja executado pelo menos uma vez
            // do
            // {
            //     statements
            // } while (condition);

            int j = 0;

            Console.WriteLine("Do While loop:");

            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);

            // For - Sabemos quantas vezes queremos repetir o bloco de código
            // for (init; cond; incr)
            // {
            //     statements
            //  }

            Console.WriteLine("For loop:");

            for (int k = 1; k < 5; k++)
            {
                Console.WriteLine(k);
            }

            // Nested Loops

            Console.WriteLine("Nested Loops:");

            for (int h = 0; h < 3; h++)
            {
                Console.WriteLine($"Externo:" + h);

                for (int l = 0; l < 2; l++)
                {
                    Console.WriteLine($"Interno:" + l);
                }
            }

            // break; continue;
            // Escrever os número de 0 a 20 e imprimi-los exceto os múltiplos de 5




        }
    }
}
