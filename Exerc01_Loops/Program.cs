using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Escreva um algoritmo para ler 10 números.
                Todos os números lidos com valor inferior a 40 devem ser somados.
                Escreva o valor final da soma efetuada.
            */

            // Declarar as variáveis
            int numero, somaMenor40 = 0;
            Console.WriteLine("Insira 10 números inteiros para calcular a soma dos números menores que 40!");
            // Ciclo de Repetição For
            for (int i = 0; i < 10; i++)
            {
                //Leitura e validação do valor recebido recebido
                do
                {
                    Console.Write($"\nInsira o {i + 1}º valor inteiro: ");
                } while (!int.TryParse(Console.ReadLine(), out numero));

                // Condição para somar os valores inferiores a 40
                if (numero < 40)
                {
                    somaMenor40 += numero;
                }
            }

            //Escrita do valor da soma de numero inferior a 40
            Console.WriteLine($"A soma dos números inferiores a 40 é: {somaMenor40}");



        }
    }
}
