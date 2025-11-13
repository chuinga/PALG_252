using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extenso
{
    internal class Program
    {
        // Escreva um programa que leia um número entre 0 e 10 e o escreva por extenso.

        static void Main(string[] args)
        {
            Console.Write("Digite um número entre 0 e 10: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                case 6:
                    Console.WriteLine("Seis");
                    break;
                case 7:
                    Console.WriteLine("Sete");
                    break;
                case 8:
                    Console.WriteLine("Oito");
                    break;
                case 9:
                    Console.WriteLine("Nove");
                    break;
                case 10:
                    Console.WriteLine("Dez");
                    break;
                default:
                    Console.WriteLine("Número inválido!");
                    break;
            }
        }
    }
}
