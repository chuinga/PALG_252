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
            //// 1. Crie uma lista de números inteiros e adicione dez valores à sua escolha. A seguir,
            //// remova todos os números pares da lista e ordene os restantes em ordem
            //// crescente.Por fim, imprima todos os números presentes na lista e indique o
            //// número total de elementos que ficaram.

            //// Criar lista vazia
            //List<int> numeros = new List<int>();

            //// Solicitar 10 números ao utilizador
            //Console.WriteLine("Introduza 10 números inteiros:");
            //for (int i = 1; i <= 10; i++)
            //{
            //    int numero;
            //    bool valido = false;

            //    while (!valido)
            //    {
            //        Console.Write($"Número {i}: ");
            //        string input = Console.ReadLine();

            //        if (int.TryParse(input, out numero))
            //        {
            //            numeros.Add(numero);
            //            valido = true;
            //        }
            //        else
            //            Console.WriteLine("Erro! Introduza um número inteiro válido.");
            //    }
            //}

            //Console.WriteLine("\nLista original:");
            //foreach (int num in numeros)
            //    Console.Write(num + " ");
            //Console.WriteLine("\n");

            //// Remover todos os números pares
            //numeros.RemoveAll(n => n % 2 == 0);

            //// Ordenar em ordem crescente
            //numeros.Sort();

            //// Imprimir lista final
            //Console.WriteLine("Lista após remover pares e ordenar:");
            //foreach (int num in numeros)
            //    Console.Write(num + " ");

            //// Indicar total de elementos
            //Console.WriteLine("\n\nNúmero total de elementos: " + numeros.Count);

            #endregion

            #region Exercício 2
            //// 2. Crie um ArrayList e adicione cinco nomes de frutas diferentes. Em seguida,
            //// acrescente mais duas frutas à lista e elimine a primeira fruta adicionada. Ordene
            //// a lista por ordem alfabética e, utilizando um ciclo foreach, imprima todos os
            //// elementos da lista. 

            //// Criar ArrayList vazio
            //ArrayList frutas = new ArrayList();

            //// Solicitar 5 frutas ao utilizador
            //Console.WriteLine("=== Adicionar 5 frutas ===");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"Fruta {i}: ");
            //    string fruta = Console.ReadLine();
            //    frutas.Add(fruta);
            //}

            //Console.WriteLine("\n=== Lista inicial de frutas ===");
            //foreach (string fruta in frutas)
            //    Console.WriteLine("- " + fruta);
            //Console.WriteLine($"Total: {frutas.Count} frutas\n");

            //// Solicitar mais duas frutas
            //Console.WriteLine("=== Adicionar mais 2 frutas ===");
            //for (int i = 1; i <= 2; i++)
            //{
            //    Console.Write($"Fruta adicional {i}: ");
            //    string fruta = Console.ReadLine();
            //    frutas.Add(fruta);
            //}

            //Console.WriteLine("\n=== Após adicionar 2 frutas ===");
            //foreach (string fruta in frutas)
            //    Console.WriteLine("- " + fruta);
            //Console.WriteLine($"Total: {frutas.Count} frutas\n");

            //// Remover a primeira fruta adicionada (índice 0)
            //Console.WriteLine($"A remover a primeira fruta: {frutas[0]}\n");
            //frutas.RemoveAt(0);

            //Console.WriteLine("=== Após remover a primeira fruta ===");
            //foreach (string fruta in frutas)
            //    Console.WriteLine("- " + fruta);
            //Console.WriteLine($"Total: {frutas.Count} frutas\n");

            //// Ordenar por ordem alfabética
            //frutas.Sort();

            //// Imprimir lista final com foreach
            //Console.WriteLine("=== Lista final ordenada alfabeticamente ===");
            //foreach (string fruta in frutas)
            //    Console.WriteLine("- " + fruta);
            //Console.WriteLine($"Total: {frutas.Count} frutas");


            #endregion

            #region Exercício 3
            // 3. Crie um dicionário para armazenar as notas de três disciplinas — Matemática,
            // Português e Ciências — de cinco alunos identificados por um número de aluno.
            // Solicite ao utilizador que introduza as notas de cada aluno em cada disciplina e
            // atualize o dicionário com esses valores. Para cada aluno, calcule a média das três
            // disciplinas e indique se o aluno se encontra aprovado (média igual ou superior a
            // 10) ou reprovado (média inferior a 10). Em seguida, liste todos os alunos com
            // média igual ou superior a 15. Por fim, permita ao utilizador consultar as notas de
            // qualquer aluno através do seu número de identificação.

            // Dicionário: chave = número do aluno, valor = dicionário com notas
            Dictionary<int, Dictionary<string, double>> alunos = new Dictionary<int, Dictionary<string, double>>();

            string[] disciplinas = new string[] { "Matemática", "Português", "Ciências" };
            int[] numerosAlunos = new int[] { 101, 102, 103, 104, 105 };

            // Solicitar as notas de cada aluno
            foreach (int numAluno in numerosAlunos)
            {
                Console.WriteLine($"\n--- Aluno {numAluno} ---");
                Dictionary<string, double> notas = new Dictionary<string, double>();

                foreach (string disciplina in disciplinas)
                {
                    double nota = 0;
                    bool valido = false;

                    while (!valido)
                    {
                        Console.Write($"Introduza a nota de {disciplina}: ");
                        string input = Console.ReadLine();

                        if (double.TryParse(input, out nota) && nota >= 0 && nota <= 20)
                            valido = true;
                        else
                            Console.WriteLine("Erro! Introduza uma nota válida entre 0 e 20.");
                    }

                    notas.Add(disciplina, nota);
                }

                alunos.Add(numAluno, notas);
            }

            // Calcular médias e mostrar aprovação
            Console.WriteLine("\n\n=== RESULTADOS ===");
            List<int> alunosMedia15 = new List<int>();

            foreach (var aluno in alunos)
            {
                int numAluno = aluno.Key;
                Dictionary<string, double> notas = aluno.Value;

                double media = notas.Values.Average();
                string situacao = media >= 10 ? "APROVADO" : "REPROVADO";

                Console.WriteLine($"\nAluno {numAluno}: Média = {media:F2} - {situacao}");

                if (media >= 15)
                    alunosMedia15.Add(numAluno);
            }

            // Listar alunos com média >= 15
            Console.WriteLine("\n\n=== ALUNOS COM MÉDIA >= 15 ===");

            if (alunosMedia15.Count > 0)
                foreach (int numAluno in alunosMedia15)
                    Console.WriteLine($"- Aluno {numAluno}");
            else
                Console.WriteLine("Nenhum aluno com média igual ou superior a 15.");

            // Consultar notas de um aluno específico
            bool consultaValida = false;

            while (!consultaValida)
            {
                Console.Write("\n\nIntroduza o número do aluno para consultar as notas (ou 0 para sair): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int alunoConsulta))
                {
                    if (alunoConsulta == 0)
                    {
                        Console.WriteLine("A sair...");
                        consultaValida = true;
                    }
                    else if (alunos.ContainsKey(alunoConsulta))
                    {
                        Console.WriteLine($"\n=== Notas do Aluno {alunoConsulta} ===");
                        foreach (var disciplina in alunos[alunoConsulta])
                            Console.WriteLine($"  {disciplina.Key}: {disciplina.Value}");

                        double media = alunos[alunoConsulta].Values.Average();
                        Console.WriteLine($"  Média: {media:F2}");
                        consultaValida = true;
                    }
                    else
                        Console.WriteLine("Aluno não encontrado! Tente novamente.");
                }
                else
                    Console.WriteLine("Erro! Introduza um número válido.");
            }

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
