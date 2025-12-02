using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matriz (array bi-dimensional) - constituída por linhas e colunas (tabela)

            // Declaração e instanciação de matrizes
            // Declarar e instanciar uma matriz de 2 x 3 de inteiros
            int[,] matriz1 = new int[2,3];

            // Declarar, instanciar e inicializar a matriz
            // matriz 3x3
            //                      0  1  2       colunas
            //          linha 0    45  2  7
            //          linha 1     1  8 23
            //          linha 2     3  7  9

            int[,] matriz2 = new int[,] { { 45, 2, 7 }, { 1, 8, 23 }, { 3, 7, 9 } };

            // Acesso direto para mostrar o valor numa posição específica
            Console.WriteLine($"Valor da linha 1, coluna 2 = {matriz2[1, 2]}");

            // Preencher uma determinada posição da matriz
            matriz2[0, 0] = 1000;

            int lin = matriz1.GetLength(0);
            int col = matriz1.GetLength(1);

            // Acesso indireto para preenchimento de todos os elementos da matriz
            for (int i = 0; i < matriz1.GetLength(0); i++) // 0 para a 1.ª dimensão (linhas)
                for (int j = 0; j < matriz1.GetLength(1); j++) // 1 para a 2.ª dimensão (colunas)
                {
                    do
                    {
                        Console.Write($"Digite o valor da linha {i} coluna {j}:     ");
                    } while (!int.TryParse(Console.ReadLine(), out matriz1[i, j])); 
                }

            Console.ReadKey();

            // Acesso indireto para mostrar os valores da matriz
            for (int i = 0; i < matriz1.GetLength(0); i++) // 0 para a 1.ª dimensão (linhas)
            {
                Console.WriteLine("\n\t");
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write($" {matriz1[i, j]}");
                }
            }
                
        }
    }
}
