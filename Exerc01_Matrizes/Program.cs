using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01_Matrizes
{
    internal class Program
    {
        /*  1.	Pretende-se um programa em C# capaz de ler uma matriz de 5*4 e escrever:
               a)	O maior elemento de cada linha da matriz;
               b)	A média dos elementos de cada coluna;
               c)	A soma dos elementos da linha 3;
               d)	A soma dos elementos de uma coluna escolhida pelo utilizador;
               e)	A soma dos elementos da diagonal principal;
               f)	A soma dos elementos de toda a matriz;
               g)	Os números de elementos da matriz iguais a um número dado;
               h)	A mudança de posição de todos os elementos da matriz, trocando o número
                   da linha pela coluna. Exemplo: o elemento da linha 3 coluna 5, passa para a coluna 3 linha 5.
        */

        static void Main(string[] args)
        {

            int[,] matriz = new int[,]
                                        {   {6,  23,  170,  5 },
                                            {40, 70 ,  6 ,  23 },
                                            {40, 180,  26,  23 },
                                            {40, 70,   6,   20 },
                                            {25, 30,   50,  12 }
                                        };


            // a) O maior elemento de cada linha da matriz;
            int maior;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                maior = int.MinValue;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > maior)
                        maior = matriz[i, j];
                }
                Console.WriteLine($"O maior valor da linha {i} = {maior}");
            }

            // b) A média dos elementos de cada coluna;
            int soma;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    soma += matriz[i, j];
                }
                Console.WriteLine($"Coluna {j} = Soma: {soma}");
                Console.WriteLine($"Média da coluna {j} = {(float)soma / matriz.GetLength(0)}");
            }

            // c) A soma dos elementos da linha 3;
            int somalinha3 = 0;

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                somalinha3 += matriz[3, j];
            }

            Console.WriteLine($"Soma dos valores da linha 3 = {somalinha3}");

            // d)	A soma dos elementos de uma coluna escolhida pelo utilizador;
            int somaColuna = 0;
            byte col;
            do
            {
                Console.WriteLine($"Diga qual a coluna que quer somar (0 a {matriz.GetLength(1) - 1}): ");
            } while (!byte.TryParse(Console.ReadLine(), out col) || col >= matriz.GetLength(1));

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                somaColuna += matriz[i, col];
            }

            Console.WriteLine($"Soma dos valores da coluna {col} = {somaColuna}");

            // e)	A soma dos elementos da diagonal principal;
            int somadiagonalp = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                        somadiagonalp += matriz[i, j];
                }

            }
            Console.WriteLine($"A soma dos valores da diagonal principal = {somadiagonalp}");

            /*  {{ 6, 23, 170, 5 },
                { 40, 70, 6, 23},
                { 40, 180, 26, 23},
                { 40, 70, 6, 20 },
                { 25, 30, 50, 12 }
            */

            // f)	A soma dos elementos de toda a matriz;
            int somaMatriz = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somaMatriz += matriz[i, j];
                }
            }

            Console.WriteLine($"A soma de todos os valores da matriz é = {somaMatriz}");

            // g)	Os números de elementos da matriz iguais a um número dado;
            int valor, cont = 0;
            do
            {
                Console.Write("Qual valor queres encontrar?  ");
            } while (!int.TryParse(Console.ReadLine(), out valor));

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == valor)
                    {
                        Console.WriteLine($"Encontrado em [{i},{j}]");
                        cont++;
                    }
                }
            }

            Console.WriteLine($"O valor {valor} aparece {cont} vez(es) na matriz.");

            /*  {{ 6, 23, 170, 5 },
                { 40, 70, 6, 23},
                { 40, 180, 26, 23},
                { 40, 70, 6, 20 },
                { 25, 30, 50, 12 }
            */

            // h)	A mudança de posição de todos os elementos da matriz, trocando o número
            //      da linha pela coluna. Exemplo: o elemento da linha 3 coluna 5, passa para a coluna 3 linha 5.
            int aux;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = i + 1; j < matriz.GetLength(1); j++)
                {
                    aux = matriz[i, j];
                    matriz[i, j] = matriz[j, i];
                    matriz[j, i] = aux;
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($" {matriz[i, j]}");
                }
                Console.WriteLine();
            }

        }
    }
}
