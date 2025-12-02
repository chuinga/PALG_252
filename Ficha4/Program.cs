using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercício 1
            // 1. Crie uma lista de números inteiros e adicione dez valores à sua escolha. A seguir,
            // remova todos os números pares da lista e ordene os restantes em ordem
            // crescente.Por fim, imprima todos os números presentes na lista e indique o
            // número total de elementos que ficaram.

            // Criar lista vazia
            List<int> numeros = new List<int>();

            // Solicitar 10 números ao utilizador
            Console.WriteLine("Introduza 10 números inteiros:");
            for (int i = 1; i <= 10; i++)
            {
                int numero;
                bool valido = false;

                while (!valido)
                {
                    Console.Write($"Número {i}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out numero))
                    {
                        numeros.Add(numero);
                        valido = true;
                    }
                    else
                        Console.WriteLine("Erro! Introduza um número inteiro válido.");
                }
            }

            Console.WriteLine("\nLista original:");
            foreach (int num in numeros)
                Console.Write(num + " ");
            Console.WriteLine("\n");

            // Remover todos os números pares
            numeros.RemoveAll(n => n % 2 == 0);

            // Ordenar em ordem crescente
            numeros.Sort();

            // Imprimir lista final
            Console.WriteLine("Lista após remover pares e ordenar:");
            foreach (int num in numeros)
                Console.Write(num + " ");

            // Indicar total de elementos
            Console.WriteLine("\n\nNúmero total de elementos: " + numeros.Count);

            #endregion

            #region Exercício 2
            // 2. Crie um ArrayList e adicione cinco nomes de frutas diferentes. Em seguida,
            // acrescente mais duas frutas à lista e elimine a primeira fruta adicionada. Ordene
            // a lista por ordem alfabética e, utilizando um ciclo foreach, imprima todos os
            // elementos da lista. 


            #endregion

            #region Exercício 3
            // 3. Crie um dicionário para armazenar as notas de três disciplinas — Matemática,
            // Português e Ciências — de cinco alunos identificados por um número de aluno.
            // Solicite ao utilizador que introduza as notas de cada aluno em cada disciplina e
            // atualize o dicionário com esses valores.Para cada aluno, calcule a média das três
            // disciplinas e indique se o aluno se encontra aprovado(média igual ou superior a
            // 10) ou reprovado(média inferior a 10). Em seguida, liste todos os alunos com
            // média igual ou superior a 15.Por fim, permita ao utilizador consultar as notas de
            // qualquer aluno através do seu número de identificação.

            #endregion

            #region Exercício 4
            // 4. Crie uma lista de strings com cinco nomes de pessoas diferentes. Pergunte ao
            // utilizador que introduza um carácter e apresente todos os nomes que contenham
            // esse carácter, ignorando diferenças entre maiúsculas e minúsculas.De seguida,
            // inverta cada nome da lista e apresente-os novamente.


            #endregion

            #region Exercício 5
            // 5. Crie um dicionário em que cada chave corresponda ao nome de um utilizador e o
            // valor associado seja uma lista de músicas da sua playlist. Adicione três
            // utilizadores, cada um com pelo menos quatro músicas na sua lista. Acrescente
            // uma nova música à playlist de um dos utilizadores e remova uma música da
            // playlist de outro. Percorra o dicionário e imprima o nome de cada utilizador
            // juntamente com todas as músicas da sua playlist e no final indique também o
            // número total de músicas de cada utilizador.

            #endregion

        }
    }
}
