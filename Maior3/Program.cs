using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior3
{
    internal class Program
    {   // Determinar o Maior de 3 Números distintos;
        // Exemplo
        // 1 2 3
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Digite o 1.º nr.: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2.º nr.: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3.º nr.: ");
            num3 = int.Parse(Console.ReadLine());
            
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("O maior número é: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("O maior número é: " + num2);
            }
            else
            {
                Console.WriteLine("O maior número é: " + num3);
            }



        }
    }
}
