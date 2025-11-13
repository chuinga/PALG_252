using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDigitos
{
    internal class Program
    {
        /*
         * Escreva um programa que leia um valor inteiro positivo
         * e menor que 1000 e determine a soma dos dígitos que formam o valor.
         * Exemplo:      453 => S = 4+5+3
         */

        static void Main(string[] args)
        {

            // Se é positivo
            // Se é maior que 1000

            int numero;

            Console.Write("Digite um número inteiro positivo menor que 1000: ");
            //numero = int.Parse(Console.ReadLine());

            // o TryParse converte a string para o tipo da variável colocando nessa variável o valor convertido caso
            // a operação de conversão seja um sucesso -> true
            // se a operação de conversão não tiver sucesso o TryParse devolve false

            //bool valido = int.TryParse(Console.ReadLine(), out numero);
            //if (valido == true)
            //    Console.WriteLine("É válido!")

            if (int.TryParse(Console.ReadLine(), out numero) && numero >= 0 && numero < 1000)
            {
                int centenas = numero / 100;
                int dezenas = (numero % 100) / 10;
                int unidades = numero % 10;
                int soma = centenas + dezenas + unidades;

                Console.WriteLine($"A soma de {centenas} + {dezenas} + {unidades} = {soma}");
            }

        }
    }
}
