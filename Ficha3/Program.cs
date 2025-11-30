using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ficha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercício1
            ////1.Elabore um algoritmo para ler 2 valores inteiros e calcular e escrever a soma dos inteiros existentes entre os 2 valores lidos(incluindo os próprios).
            ////a) Considere que o segundo valor lido será sempre maior que o primeiro valor lido.
            ////b) Altere o programa para que funcione independentemente da ordem de entrada dos números.
            //Console.WriteLine("=== Soma de inteiros entre dois valores ===");

            //int valor1, valor2, soma = 0;

            //// Leitura e validação do primeiro valor
            //Console.Write("Insira o primeiro valor inteiro: ");
            //while (!int.TryParse(Console.ReadLine(), out valor1))
            //    Console.Write("Valor inválido! Insira um número inteiro: ");

            //// Leitura e validação do segundo valor
            //Console.Write("Insira o segundo valor inteiro: ");
            //while (!int.TryParse(Console.ReadLine(), out valor2))
            //    Console.Write("Valor inválido! Insira um número inteiro: ");

            //// Exercício 1b: Garantir que valor1 é sempre o menor
            //if (valor1 > valor2)
            //{
            //    int temp = valor1;
            //    valor1 = valor2;
            //    valor2 = temp;
            //}

            //// Calcular soma usando for
            //for (int i = valor1; i <= valor2; i++)
            //    soma += i;

            //Console.WriteLine($"\nA soma dos inteiros entre {valor1} e {valor2} é: {soma}");

            #endregion

            #region Exercício2
            ////2.Reescreva o programa anterior para que dê apenas o somatório dos números pares.
            //Console.WriteLine("=== Soma dos números PARES entre dois valores ===");

            //int valor1, valor2, somaPares = 0;

            //// Leitura e validação
            //Console.Write("Insira o primeiro valor: ");
            //while (!int.TryParse(Console.ReadLine(), out valor1))
            //    Console.Write("Valor inválido! Tente novamente: ");

            //Console.Write("Insira o segundo valor: ");
            //while (!int.TryParse(Console.ReadLine(), out valor2))
            //    Console.Write("Valor inválido! Tente novamente: ");

            //// Garantir ordem correta
            //if (valor1 > valor2)
            //{
            //    int temp = valor1;
            //    valor1 = valor2;
            //    valor2 = temp;
            //}

            //// Calcular soma dos pares usando for
            //Console.Write("\nNúmeros pares: ");
            //for (int i = valor1; i <= valor2; i++)
            //{
            //    if (i % 2 == 0) // Verifica se é par
            //    {
            //        somaPares += i;
            //        Console.Write($"{i} ");
            //    }
            //}

            //Console.WriteLine($"\n\nA soma dos números pares é: {somaPares}");

            #endregion

            #region Exercício3
            ////3.O João tem 1,50 metros e cresce 2 centímetros por ano, enquanto o Zé tem 1,10 metros e cresce 3 centímetros por ano.Construa um algoritmo que calcule e 
            ////mostre quantos anos serão necessários para que Zé seja maior que João.
            //Console.WriteLine("=== Crescimento do João e do Zé ===");

            //// Dados iniciais (em centímetros para facilitar cálculos)
            //double alturaJoao = 150;  // 1,50m = 150cm
            //double alturaZe = 110;    // 1,10m = 110cm
            //int anos = 0;

            //// Usar while para calcular quantos anos são necessários
            //while (alturaZe <= alturaJoao)
            //{
            //    anos++;
            //    alturaJoao += 2;  // Cresce 2cm por ano
            //    alturaZe += 3;    // Cresce 3cm por ano
            //}

            //Console.WriteLine($"Serão necessários {anos} anos para que o Zé seja maior que o João.");
            //Console.WriteLine($"\nApós {anos} anos:");
            //Console.WriteLine($"- João terá: {alturaJoao / 100:F2}m");
            //Console.WriteLine($"- Zé terá: {alturaZe / 100:F2}m");

            #endregion

            #region Exercício4
            ////4.Elabore um algoritmo para ler n números, determinar o maior, o menor e a média dos n números lidos.
            //Console.WriteLine("=== Cálculo de Maior, Menor e Média ===");

            //int n;

            //// Validar quantidade de números
            //do
            //{
            //    Console.Write("Quantos números deseja inserir? ");
            //} while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            //double numero, soma = 0;
            //double maior = double.MinValue;
            //double menor = double.MaxValue;

            //// Ler n números usando for
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"Insira o {i}º número: ");
            //    while (!double.TryParse(Console.ReadLine(), out numero))
            //        Console.Write("Valor inválido! Tente novamente: ");

            //    soma += numero;

            //    // Atualizar maior e menor
            //    if (numero > maior)
            //        maior = numero;

            //    if (numero < menor)
            //        menor = numero;
            //}

            //double media = soma / n;

            //Console.WriteLine("\n=== RESULTADOS ===");
            //Console.WriteLine($"Maior número: {maior}");
            //Console.WriteLine($"Menor número: {menor}");
            //Console.WriteLine($"Média: {media:F2}");


            #endregion

            #region Exercício5
            ////5.Foi realizada uma pesquisa entre os habitantes de uma dada região.
            ////Foram recolhidos os dados de idade, sexo (M / F) e salário. Construa um programa que mostre:
            ////a) A média de salário do grupo.
            ////b) Maior e menor idade do grupo.
            ////c) Quantidade de mulheres com salário até 800 euros.
            //Console.WriteLine("=== Pesquisa entre Habitantes ===");

            //int numPessoas;

            //do
            //{
            //    Console.Write("Quantas pessoas serão pesquisadas? ");
            //} while (!int.TryParse(Console.ReadLine(), out numPessoas) || numPessoas <= 0);

            //double somaSalarios = 0;
            //int idadeMaior = int.MinValue;
            //int idadeMenor = int.MaxValue;
            //int mulheresSalarioAte800 = 0;

            //// Loop principal usando for
            //for (int i = 1; i <= numPessoas; i++)
            //{
            //    Console.WriteLine($"\n--- Pessoa {i} ---");

            //    // Ler idade
            //    int idade;
            //    do
            //    {
            //        Console.Write("Idade: ");
            //    } while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0 || idade > 120);

            //    // Ler sexo
            //    char sexo;
            //    do
            //    {
            //        Console.Write("Sexo (M/F): ");
            //        string input = Console.ReadLine().ToUpper();
            //        sexo = input.Length > 0 ? input[0] : ' ';
            //    } while (sexo != 'M' && sexo != 'F');

            //    // Ler salário
            //    double salario;
            //    do
            //    {
            //        Console.Write("Salário (EUR): ");
            //    } while (!double.TryParse(Console.ReadLine(), out salario) || salario < 0);

            //    // Processar dados
            //    somaSalarios += salario;

            //    if (idade > idadeMaior)
            //        idadeMaior = idade;

            //    if (idade < idadeMenor)
            //        idadeMenor = idade;

            //    if (sexo == 'F' && salario <= 800)
            //        mulheresSalarioAte800++;
            //}

            //// Mostrar resultados
            //Console.WriteLine("\n=== RESULTADOS DA PESQUISA ===");
            //Console.WriteLine($"a) Média de salário: {somaSalarios / numPessoas:F2}EUR");
            //Console.WriteLine($"b) Maior idade: {idadeMaior} anos");
            //Console.WriteLine($"   Menor idade: {idadeMenor} anos");
            //Console.WriteLine($"c) Mulheres com salário até 800EUR: {mulheresSalarioAte800}");

            #endregion

            #region Exercício6
            ////6.Elabore um algoritmo para ler o género e a idade de 50 pessoas e indique quantas pessoas são do género feminino e são maiores de idade e também a média dessas idades. 
            ////O algoritmo deve ainda apresentar a percentagem de homens no universo da pesquisa.
            //Console.WriteLine("=== Pesquisa de Género e Idade (50 pessoas) ===");

            //const int TOTAL_PESSOAS = 50;
            //int mulheresMaiores = 0;
            //double somaIdadesMulheresMaiores = 0;
            //int homens = 0;

            //// Loop para 50 pessoas
            //for (int i = 1; i <= TOTAL_PESSOAS; i++)
            //{
            //    Console.WriteLine($"\n--- Pessoa {i}/{TOTAL_PESSOAS} ---");

            //    // Ler género
            //    char genero;
            //    do
            //    {
            //        Console.Write("Género (M/F): ");
            //        string input = Console.ReadLine().ToUpper();
            //        genero = input.Length > 0 ? input[0] : ' ';
            //    } while (genero != 'M' && genero != 'F');

            //    // Ler idade
            //    int idade;
            //    do
            //    {
            //        Console.Write("Idade: ");
            //    } while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0 || idade > 120);

            //    // Processar dados
            //    if (genero == 'M')
            //    {
            //        homens++;
            //    }
            //    else if (genero == 'F' && idade >= 18)
            //    {
            //        mulheresMaiores++;
            //        somaIdadesMulheresMaiores += idade;
            //    }
            //}

            //// Calcular percentagem de homens
            //double percentagemHomens = (homens * 100.0) / TOTAL_PESSOAS;

            //// Calcular média de idades
            //double mediaIdadesMulheresMaiores = mulheresMaiores > 0
            //    ? somaIdadesMulheresMaiores / mulheresMaiores
            //    : 0;

            //// Mostrar resultados
            //Console.WriteLine("\n=== RESULTADOS ===");
            //Console.WriteLine($"Mulheres maiores de idade: {mulheresMaiores}");
            //Console.WriteLine($"Média de idades (mulheres maiores): {mediaIdadesMulheresMaiores:F2} anos");
            //Console.WriteLine($"Percentagem de homens: {percentagemHomens:F2}%");

            #endregion

            #region Exercício7
            ////7.Elabore um algoritmo com o objetivo de determinar o valor, ao fim de n anos, de um depósito bancário de quantia q, sabendo que a taxa de juro inicial j(superior a 5, 0 %), 
            ////decresce todos os anos de um valor de 0,5 % até atingir o mínimo de 5,0 %.
            ////• Suponha que os juros são sempre capitalizados.
            ////• Indique para cada ano, o capital inicial, a taxa de juro, juros e capital final.
            //Console.WriteLine("=== Simulador de Depósito Bancário ===");

            //// Ler quantia inicial
            //double quantia;
            //do
            //{
            //    Console.Write("Quantia inicial do depósito (EUR): ");
            //} while (!double.TryParse(Console.ReadLine(), out quantia) || quantia <= 0);

            //// Ler taxa de juro inicial
            //double taxaJuro;
            //do
            //{
            //    Console.Write("Taxa de juro inicial (%, superior a 5.0): ");
            //} while (!double.TryParse(Console.ReadLine(), out taxaJuro) || taxaJuro <= 5.0);

            //// Ler número de anos
            //int anos;
            //do
            //{
            //    Console.Write("Número de anos: ");
            //} while (!int.TryParse(Console.ReadLine(), out anos) || anos <= 0);

            //double capitalAtual = quantia;

            //Console.WriteLine("\n=== EVOLUÇÃO DO DEPÓSITO ===");
            //Console.WriteLine($"{"Ano",-6} {"Capital Inicial",-18} {"Taxa",-8} {"Juros",-15} {"Capital Final",-18}");
            //Console.WriteLine(new string('-', 70));

            //// Usar for para simular cada ano
            //for (int ano = 1; ano <= anos; ano++)
            //{
            //    double capitalInicial = capitalAtual;
            //    double juros = capitalAtual * (taxaJuro / 100);
            //    capitalAtual = capitalInicial + juros;

            //    Console.WriteLine($"{ano,-6} {capitalInicial,-18:F2} {taxaJuro,-8:F2}% {juros,-15:F2} {capitalAtual,-18:F2}");

            //    // Reduzir taxa de juro (mínimo 5.0%)
            //    if (taxaJuro > 5.0)
            //    {
            //        taxaJuro -= 0.5;
            //        if (taxaJuro < 5.0)
            //            taxaJuro = 5.0;
            //    }
            //}

            //Console.WriteLine($"\nValor final após {anos} anos: {capitalAtual:F2}EUR");

            #endregion

            #region Exercício8
            ////8.Um mês antes das eleições municipais, um determinado partido político encomendou uma pesquisa de opinião sobre as intenções de voto dos eleitores. Foram entrevistadas 80 pessoas 
            ////que indicaram as suas intenções de acordo com as seguintes opções:
            ////A – candidato A
            ////B – candidato B
            ////C – indecisos
            ////D – Não vão votar
            ////Desenvolva um algoritmo que faça a leitura das intenções de voto dessas 80 pessoas e que informe a percentagem das intenções para cada opção existente.
            //Console.WriteLine("=== Pesquisa de Intenções de Voto ===");
            //Console.WriteLine("Opções disponíveis:");
            //Console.WriteLine("A - Candidato A");
            //Console.WriteLine("B - Candidato B");
            //Console.WriteLine("C - Indecisos");
            //Console.WriteLine("D - Não vão votar");
            //Console.WriteLine();

            //const int TOTAL_ENTREVISTADOS = 80;
            //int votosA = 0;
            //int votosB = 0;
            //int indecisos = 0;
            //int naoVotam = 0;

            //// Loop para entrevistar 80 pessoas usando for
            //for (int i = 1; i <= TOTAL_ENTREVISTADOS; i++)
            //{
            //    char opcao;
            //    bool entradaValida;

            //    // Validação da entrada usando do-while
            //    do
            //    {
            //        Console.Write($"Entrevistado {i}/{TOTAL_ENTREVISTADOS} - Intenção de voto (A/B/C/D): ");
            //        string input = Console.ReadLine().ToUpper();

            //        // Verificar se a entrada tem pelo menos 1 caractere
            //        if (input.Length > 0)
            //        {
            //            opcao = input[0];
            //            entradaValida = (opcao == 'A' || opcao == 'B' || opcao == 'C' || opcao == 'D');

            //            if (entradaValida)
            //                // Contabilizar voto
            //                switch (opcao)
            //                {
            //                    case 'A':
            //                        votosA++;
            //                        break;
            //                    case 'B':
            //                        votosB++;
            //                        break;
            //                    case 'C':
            //                        indecisos++;
            //                        break;
            //                    case 'D':
            //                        naoVotam++;
            //                        break;
            //                }
            //            else
            //                Console.WriteLine("Opção inválida! Use apenas A, B, C ou D.");
            //        }
            //        else
            //        {
            //            entradaValida = false;
            //            Console.WriteLine("Entrada vazia! Por favor, insira uma opção.");
            //        }
            //    } while (!entradaValida);
            //}

            //// Calcular percentagens
            //double percentagemA = (votosA * 100.0) / TOTAL_ENTREVISTADOS;
            //double percentagemB = (votosB * 100.0) / TOTAL_ENTREVISTADOS;
            //double percentagemC = (indecisos * 100.0) / TOTAL_ENTREVISTADOS;
            //double percentagemD = (naoVotam * 100.0) / TOTAL_ENTREVISTADOS;

            //// Mostrar resultados
            //Console.WriteLine("\n" + new string('=', 60));
            //Console.WriteLine("RESULTADOS DA PESQUISA DE INTENÇÕES DE VOTO");
            //Console.WriteLine(new string('=', 60));
            //Console.WriteLine($"Total de entrevistados: {TOTAL_ENTREVISTADOS}");
            //Console.WriteLine();
            //Console.WriteLine($"Candidato A:");
            //Console.WriteLine($"  - Votos: {votosA}");
            //Console.WriteLine($"  - Percentagem: {percentagemA:F2}%");
            //Console.WriteLine();
            //Console.WriteLine($"Candidato B:");
            //Console.WriteLine($"  - Votos: {votosB}");
            //Console.WriteLine($"  - Percentagem: {percentagemB:F2}%");
            //Console.WriteLine();
            //Console.WriteLine($"Indecisos:");
            //Console.WriteLine($"  - Total: {indecisos}");
            //Console.WriteLine($"  - Percentagem: {percentagemC:F2}%");
            //Console.WriteLine();
            //Console.WriteLine($"Não vão votar:");
            //Console.WriteLine($"  - Total: {naoVotam}");
            //Console.WriteLine($"  - Percentagem: {percentagemD:F2}%");
            //Console.WriteLine(new string('=', 60));

            //// Análise adicional - determinar o candidato na frente
            //if (votosA > votosB)
            //    Console.WriteLine($"\n>>> O Candidato A está na frente com {percentagemA:F2}% das intenções!");
            //else if (votosB > votosA)
            //    Console.WriteLine($"\n>>> O Candidato B está na frente com {percentagemB:F2}% das intenções!");
            //else
            //    Console.WriteLine($"\n>>> Empate técnico entre os candidatos A e B!");

            #endregion

            #region Exercício9
            ////9.
            ////Uma determinada empresa fez uma pesquisa de mercado para saber se as pessoas gostaram ou não de um novo produto que foi lançado. Para cada pessoa entrevistada foram coletados os seguintes dados:
            ////• Género(M ou F) e
            ////• Resposta(Gostou ou Não Gostou – S / N)
            ////Sabendo que foram entrevistadas 50 pessoas, faça um programa que forneça:
            ////• Número de pessoas que gostaram do produto.
            ////• Número de pessoas que não gostaram do produto
            ////• Percentagem de pessoas do género masculino que não gostaram do produto.
            ////• Informação dizendo em que género o produto teve melhor aceitação.
            //Console.WriteLine("=== Pesquisa de Aceitação de Novo Produto ===");
            //Console.WriteLine("50 pessoas serão entrevistadas");
            //Console.WriteLine();

            //const int TOTAL_ENTREVISTADOS = 10;

            //// Contadores gerais
            //int gostaram = 0;
            //int naoGostaram = 0;

            //// Contadores por género
            //int homensGostaram = 0;
            //int homensNaoGostaram = 0;
            //int mulheresGostaram = 0;
            //int mulheresNaoGostaram = 0;

            //// Loop para entrevistar 50 pessoas usando for
            //for (int i = 1; i <= TOTAL_ENTREVISTADOS; i++)
            //{
            //    Console.WriteLine($"--- Entrevistado {i}/{TOTAL_ENTREVISTADOS} ---");

            //    // Ler género com validação
            //    char genero;
            //    do
            //    {
            //        Console.Write("Género (M/F): ");
            //        string inputGenero = Console.ReadLine().ToUpper();
            //        genero = inputGenero.Length > 0 ? inputGenero[0] : ' ';

            //        if (genero != 'M' && genero != 'F')
            //            Console.WriteLine("Género inválido! Use M para Masculino ou F para Feminino.");
            //    } while (genero != 'M' && genero != 'F');

            //    // Ler resposta com validação
            //    char resposta;
            //    do
            //    {
            //        Console.Write("Gostou do produto? (S/N): ");
            //        string inputResposta = Console.ReadLine().ToUpper();
            //        resposta = inputResposta.Length > 0 ? inputResposta[0] : ' ';

            //        if (resposta != 'S' && resposta != 'N')
            //            Console.WriteLine("Resposta inválida! Use S para Sim ou N para Não.");
            //    } while (resposta != 'S' && resposta != 'N');

            //    // Processar dados
            //    if (resposta == 'S')
            //    {
            //        gostaram++;

            //        if (genero == 'M')
            //            homensGostaram++;
            //        else
            //            mulheresGostaram++;
            //    }
            //    else // resposta == 'N'
            //    {
            //        naoGostaram++;

            //        if (genero == 'M')
            //            homensNaoGostaram++;
            //        else
            //            mulheresNaoGostaram++;
            //    }

            //    Console.WriteLine(); // Linha em branco para melhor visualização
            //}

            //// Calcular totais por género
            //int totalHomens = homensGostaram + homensNaoGostaram;
            //int totalMulheres = mulheresGostaram + mulheresNaoGostaram;

            //// Calcular percentagem de homens que não gostaram
            //double percentagemHomensNaoGostaram = totalHomens > 0
            //    ? (homensNaoGostaram * 100.0) / totalHomens
            //    : 0;

            //// Calcular percentagens de aceitação por género
            //double percentagemAceitacaoHomens = totalHomens > 0
            //    ? (homensGostaram * 100.0) / totalHomens
            //    : 0;

            //double percentagemAceitacaoMulheres = totalMulheres > 0
            //    ? (mulheresGostaram * 100.0) / totalMulheres
            //    : 0;

            //// Determinar melhor aceitação
            //string melhorAceitacao;
            //if (percentagemAceitacaoHomens > percentagemAceitacaoMulheres)
            //    melhorAceitacao = "MASCULINO";
            //else if (percentagemAceitacaoMulheres > percentagemAceitacaoHomens)
            //    melhorAceitacao = "FEMININO";
            //else
            //    melhorAceitacao = "IGUAL em ambos os géneros";

            //// Mostrar resultados
            //Console.WriteLine(new string('=', 70));
            //Console.WriteLine("RESULTADOS DA PESQUISA DE ACEITAÇÃO DO PRODUTO");
            //Console.WriteLine(new string('=', 70));
            //Console.WriteLine();

            //Console.WriteLine(">>> DADOS GERAIS:");
            //Console.WriteLine($"    • Pessoas que gostaram do produto: {gostaram} ({(gostaram * 100.0 / TOTAL_ENTREVISTADOS):F2}%)");
            //Console.WriteLine($"    • Pessoas que NÃO gostaram do produto: {naoGostaram} ({(naoGostaram * 100.0 / TOTAL_ENTREVISTADOS):F2}%)");
            //Console.WriteLine();

            //Console.WriteLine(">>> DADOS POR GÉNERO:");
            //Console.WriteLine($"    HOMENS (Total: {totalHomens}):");
            //Console.WriteLine($"      - Gostaram: {homensGostaram} ({percentagemAceitacaoHomens:F2}%)");
            //Console.WriteLine($"      - Não gostaram: {homensNaoGostaram} ({percentagemHomensNaoGostaram:F2}%)");
            //Console.WriteLine();
            //Console.WriteLine($"    MULHERES (Total: {totalMulheres}):");
            //Console.WriteLine($"      - Gostaram: {mulheresGostaram} ({percentagemAceitacaoMulheres:F2}%)");
            //Console.WriteLine($"      - Não gostaram: {mulheresNaoGostaram}");
            //Console.WriteLine();

            //Console.WriteLine(">>> ANÁLISE:");
            //Console.WriteLine($"    • Percentagem de homens que NÃO gostaram: {percentagemHomensNaoGostaram:F2}%");
            //Console.WriteLine($"    • Género com melhor aceitação: {melhorAceitacao}");

            //if (melhorAceitacao != "IGUAL em ambos os géneros")
            //{
            //    double maiorPercentagem = Math.Max(percentagemAceitacaoHomens, percentagemAceitacaoMulheres);
            //    Console.WriteLine($"      (Taxa de aceitação: {maiorPercentagem:F2}%)");
            //}

            //Console.WriteLine(new string('=', 70));

            //// Conclusão adicional
            //Console.WriteLine();
            //if (gostaram > naoGostaram)
            //    Console.WriteLine("CONCLUSÃO: O produto teve aceitação POSITIVA no mercado!");
            //else if (naoGostaram > gostaram)
            //    Console.WriteLine("CONCLUSÃO: O produto teve aceitação NEGATIVA no mercado!");
            //else
            //    Console.WriteLine("CONCLUSÃO: O produto teve aceitação MISTA (opiniões divididas).");

                #endregion



        }
    }
}
