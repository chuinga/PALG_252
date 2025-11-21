using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // if
            // if (condition)
            // {
            //     statement if true
            // }

            double doub = 12.65;

            if ( (doub > 20.22))
            {
                Console.WriteLine("Double grande");
            }

            // if (condition)
            // {statement}
            // else
            // {statement}

            byte idade = 25;

            if ( idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }

            // if (condition)
            // {statement}
            // else if (condition) 
            // {statement}
            // else
            // {statement}

            int time = 22;

            if (time < 10)
            {
                Console.WriteLine("Bom dia");
            }
            else if (time < 20)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

            // Operador Ternário – Short Hand If Else
            // exp1 ? exp2 : exp3;

            // Declarar e atribuir um valor e se for positivo apresentar a sua metade senão apresentar o seu quadrado

            float num = 12.6f;

            float resultado = (num >= 0 ? num / 2 : num * num);

            Console.WriteLine($"Resultado: {(num >= 0 ? num / 2 : num * num)}");
            Console.WriteLine($"Resultado: {resultado}");

            // Switch Case
            // switch (expression)
            // {
            //     case x:
            //         statement;
            //         break;
            //     case y:
            //         statement;
            //         break;
            //     default:
            //         statement;
            //         break;
            //  }

            int dia = 5;

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-feira");
                    break;
                case 3:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Not in range");
                    break;
            }

            // Operadores Lógicos
            // && (AND)
            // || (OR)
            // ! (NOT)

        }
    }
}
