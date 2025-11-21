using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays Unidimensional
            // Um array unidimensional é também conhecido por vetor
            // <tipodedados>[] nomeArray = new <tipodedados>[dimensao];
            int[] numeros = new int[3]; // Declaração do array numeros do tipo int e instanciação do mesmo com a dimensão 3 
            //Acesso direto para preencher uma posição do array
            //numeros[1] = 6; //Atribuo o valor 6 à posição 1 do array numeros
            //numeros[2] = 8;
            //numeros[0] = -10;
            //Acesso direto mostrar o conteúdo da posição do array
            Console.WriteLine($"numeros[0]={numeros[0]}");
            string[] nomes = new string[] { "Diego", "Lucas", "Frederico", "Marco", "Ana" }; //Declarar, instanciar e inicializar o array de
                                                                                             //strings com os valores indicados.
                                                                                             // O número de elementos determina a dimensão do array

            int dim; //Declarar uma variável para receber a dimensão do array
            float[] numeros2;

            dim = 5;

            //numeros2 = new float[dim];

            //Acesso indireto para preencher o array
            //for (int i = 0; i < numeros2.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Escreve o valor para a posição [{i}]: ");
            //    } while (!float.TryParse(Console.ReadLine(), out numeros2[i]));
            //}

            ////Acesso indirecto mostrar os valores do array
            //Console.WriteLine("Mostrar os valores do array:");
            //for (int i = 0; i < numeros2.Length; i++)
            //{
            //    Console.WriteLine($"numeros2[{i}] = {numeros2[i]}");
            //}

            // Foreach - Acesso ao vetor para mostrar os valores armazenados
            // Usado para fazer o percurso em coleções de elementos - arrays, listas....

            //Console.WriteLine("Exibir os valores com o foreach:");
            //foreach (float num in numeros2)
            //{
            //    Console.Write($" {num}");
            //}

            ////Copiar de um array para outro
            //int[] copiaNumeros = new int[3];
            //Array.Copy(numeros, copiaNumeros, 2); //Array.Copy(arrayOriginal, arrayCopia, posiçõesacopiar)
            //                                      //numeros e copiaNumeros têm endereços de memória diferentes

            //Console.WriteLine("Mostrar os valores do CopiaNumeros");
            //foreach (int num in copiaNumeros)
            //    Console.Write($"    {num}");

            ////Atribuir um array a outro array
            //int[] valores1 = new int[] { 4, 2, 1, 3 };
            //int[] valores2 = new int[valores1.Length];
            //valores2 = valores1; //valores2 tem o mesmo endereço de memória do valores1

            //valores1[1] = 100;

            //Console.WriteLine("Mostrar o valor de Valores1 Array");
            //foreach (int num in valores1)
            //    Console.Write($"   {num}");

            //Console.WriteLine("Mostrar o valor de Valores2 Array");
            //foreach (int num in valores2)
            //    Console.Write($"   {num}");

            ////Retornar os indíces da ocorrência
            //Array.IndexOf(numeros, 8); // Retorna o indíce da primeira ocorrência de um item dentro de um array
            //Array.LastIndexOf(numeros, 8); // Retorna o indíce da última ocorrência de um item dentro de um array

            //Array.Clear(numeros, 1, 2); //Permite limpar os elemento de um array de uma determinada posição e com um determinado comprimento (length)

            //Array.Resize(ref numeros, 6); // O array numeros passa a ter a dimensao 6

            // Sorting
            // Algoritmo Bubble Sort
            // Arrays Pequenos + Educativo + Ambientes restritos de memória + customizar de forma específica
            numeros = new int[] { 6, 3, 1, 2, 5 };
            int n = numeros.Length;

            for (int i = 0; i < n - 1; i++) // Determinar o número de vezes pelas quais vamos passar pelo array
            {
                for (int j = 0; j < n - i - 1; j++) // Dentro de cada passagem, comparar e fazer a troca de pares adjacentes
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        // Trocar o numeros[j] e numeros[j+1]
                        int tmp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = tmp;
                    }
                }
            }

            // percurso i = 0               percurso i = 1              percurso i = 2              perscurso i = 3
            // j  j+1                          j                              j                           j
            // 6  3  1  2  5                1  6  3  2  5               1  2  6  3  5               1  2  3  6  5
            // j                            1  3  6  2  5               1  2  3  6  5               1  2  3  5  6 - a ordenação está concluída
            // 3  6  1  2  5                1  2  6  3  5
            // 
            // 1  6  3  2  5
            //
            // 

            // Selection Sort + ......
            Console.WriteLine("\nArray Organizado Crescentemente:");
            Array.Sort(numeros); // Método de ordenação interno do .NET - QuickSort + HeapSort

            foreach (int va in numeros)
                Console.Write($" {va}");

            Console.WriteLine("\nArray Organizado Decrescentemente:");
            Array.Reverse(numeros); // Inverter a ordem dos elementos do array

            #endregion

            #region Random Numbers
            Console.WriteLine("\nNúmeros Aleatórios:");
            // Preencher um array com valores gerados aleatoriamente e apresentar estatísticas desses valores
            int[] aleatorios = new int[50];

            // Classe Random
            Random rand = new Random();  // Instanciar um objeto rand da classe Random

            int num1;
            // Percorrer o array para preencher com valores aleatórios aos elementos do array aleatorios
            for (int i = 0; i < aleatorios.Length; i++)
            {
                num1 = rand.Next(1, 101); // Gera um número aleatório entre 1 e 100
                aleatorios[i] = num1;
            }

            // Exibir o array de aleatórios gerados
            foreach (int v in aleatorios)
            {
                Console.Write($" {v}");
            }

            Console.WriteLine("\nEstatísticas de Array:");
            Console.WriteLine($"Soma total dos valores do array: {aleatorios.Sum()}");
            Console.WriteLine($"Média dos valores do array: {aleatorios.Average()}");
            Console.WriteLine($"Valor Mínimo do array: {aleatorios.Min()}");
            Console.WriteLine($"Valor Máximo do array: {aleatorios.Max()}");

            Console.WriteLine("Array Organizado Crescentemente");
            Array.Sort(aleatorios);

            foreach (int va in aleatorios)
                Console.Write($" {va}");




            #endregion

            #region Listas


            #endregion
        }
    }
}
