using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operandos
{
    internal class Program
    {
        /*
         * Elabore um algoritmo que permite realizar uma máquina de calcular
         * para as quatro operações aritméticas básicas (+,-,*,/), com apenas dois operandos.
         */

        static void Main(string[] args)
        {
            double num1, num2;
            char op;

            Console.Write("Insira o 1º operando: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Insira a operação: ");
            op = char.Parse(Console.ReadLine());
            Console.Write("Insira o 2º operando: ");
            num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"{num1} {op} {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} {op} {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} {op} {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"{num1} {op} {num2} = {num1 / num2}");
                    else
                        Console.WriteLine("Erro: Divisão por zero!");
                    break;
            }
        }
    }
}
