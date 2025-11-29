using System;
using System.Collections;
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
                                        //Console.WriteLine($"numeros[0]={numeros[0]}");
                                        //string[] nomes = new string[] { "Diego", "Lucas", "Frederico", "Marco", "Ana" }; //Declarar, instanciar e inicializar o array de
                                        //                                                                                 //strings com os valores indicados.
                                        //                                                                                 // O número de elementos determina a dimensão do array

            //int dim; //Declarar uma variável para receber a dimensão do array
            //float[] numeros2;
            //dim = 5;
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
            //foreach(int num in copiaNumeros)
            //    Console.Write($"    {num}");

            ////Atribuir um array a outro array
            //int[] valores1 = new int[] { 4, 2, 1, 3 };
            //int[] valores2 = new int[valores1.Length];
            //valores2 = valores1; //valores2 tem o mesmo endereço de memória do valores1

            //valores1[1] = 100;

            //Console.WriteLine("Mostrar o valor de Valores1 Array");
            //foreach(int num in valores1)
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
            // Algoritmo Bubble Sort - de forma crescente
            // Arrays Pequenos + Educativa + Ambientes restritos (pouca memória) + customizar de forma específica o sorting
            //numeros = new int[] { 6, 3, 1, 2, 5 };
            //int n = numeros.Length;

            //for (int i = 0; i < n - 1; i++) // Determinar o número de vezes pelas quais vamos passar pelo array
            //{
            //    for (int j = 0; j < n - i - 1; j++) // Dentro de cada passagem, comparar e fazer a troca de pares adjacentes
            //    {
            //        if (numeros[j] > numeros[j + 1])
            //        {
            //            // Trocar o numeros[j] e numeros[j+1]
            //            int tmp = numeros[j];
            //            numeros[j] = numeros[j + 1];
            //            numeros[j + 1] = tmp;
            //        }
            //    }
            //}
            //// percurso i = 0               percurso i = 1              percurso i = 2          percurso i = 3
            // j  j+1                          j                              j   
            // 6  3  1  2  5                1  6  3  2  5               1  2  6  3  5           1  2  3  6  5
            // j                            1  3  6  2  5               1  2  3  6  5           1  2  3  5  6  - ordenação está feita
            // 3  6  1  2  5                1  2  6  3  5
            // 1  6  3  2  5                

            //Console.WriteLine("\nBubbleSort Crescente:");
            //foreach (int va in numeros)
            //    Console.Write($" {va}");

            //// Selection Sort + ... 
            //Console.WriteLine("\nSort Crescente:");
            //Array.Sort(numeros); // Ordenar o array de forma crescente

            //foreach (int va in numeros)
            //    Console.Write($" {va}");
            //Console.WriteLine("\nSort Decrescente:");
            //Array.Reverse(numeros); // Ordenar o array de forma decrescente
            //foreach (int va in numeros)
            //    Console.Write($" {va}");

            #endregion

            //#region Random Numbers
            //Console.WriteLine("\nNúmeros aleatórios:");
            //// Preencher um array com números gerados aleatoriamente e apresentar as estatísticas desses valores
            //int[] aleatorios = new int[50];

            //// Classe Random
            //Random rand = new Random(); // Instanciar o objeto rand da classe random

            //int num1;
            ////Percorrer o array e atribuir os valores aleatórios aos elementos do array aleatorios
            //for (int i = 0; i < aleatorios.Length; i++) 
            //{
            //    num1 = rand.Next(1,1001);
            //    aleatorios[i] = num1;
            //}

            //// Exibir o array de aleatórios gerado
            //foreach (int v in aleatorios)
            //{
            //    Console.Write($" {v}");
            //}

            //Console.WriteLine("\nEstatísticas de Array:");
            //Console.WriteLine($"Soma total dos valores do array: {aleatorios.Sum()}");
            //Console.WriteLine($"Média dos valores do array: {aleatorios.Average()}");
            //Console.WriteLine($"Mínimo do array: {aleatorios.Min()}");
            //Console.WriteLine($"Máximo do array: {aleatorios.Max()}");

            //Console.WriteLine("Array Organizado Crescentemente");
            //Array.Sort(aleatorios);

            //foreach (int va in aleatorios)
            //    Console.Write($" {va}");
            //#endregion

            #region Listas
            //const int DIM = 5;
            //// List<T> 
            //// Declarar e instanciar - List<tipodedado> nomeLista = new List<tipodedado>();
            //List<int> listaNum = new List<int>();

            //// Percorrer a lista para adicionar valores
            //int num;

            //for (int i = 0; i < DIM; i++) 
            //{
            //    do
            //    {
            //        Console.Write($"Insira o {listaNum.Count + 1}º valor: ");
            //    } while (!int.TryParse(Console.ReadLine(), out num));

            //    listaNum.Add(num); // Adiciona á lista o numero num - no fim da lista
            //}

            //Console.WriteLine("Mostra a lista com o loop for:");

            //for (int i = 0; i < listaNum.Count; i++) 
            //{
            //    Console.Write($" {listaNum[i]}");
            //}

            //Console.WriteLine("Mostra a lista com o loop foreach:");

            //foreach (int v in listaNum)
            //    Console.Write($"{v}");

            //Console.WriteLine("Remover o valor da posição 2");
            //listaNum.RemoveAt(2); // remover o elemento da posição indicada

            //Console.WriteLine("Remover o valor 20");
            //listaNum.Remove(20); // Remover a primeira ocorrência do valor indicado

            //Console.WriteLine("Remover todos os valores 20 da lista");
            //listaNum.RemoveAll(x => x == 20); // Remover todas as ocorrências do número 20 da lista

            //Console.WriteLine("Inserir o valor 10 na posição 1:");
            //listaNum.Insert(1, 10);

            //// Sorting
            //listaNum.Sort();

            //// Limpar todos os elementos da lista
            //// listaNum.Clear();

            //// Recuperar o indice de determinado elemento: 10
            //listaNum.IndexOf(10);

            //// Verificar se determinado valor existe na lista
            //if (listaNum.Contains(10))
            //    Console.WriteLine("Contains 10");
            //else
            //    Console.WriteLine("Doesn't Contain 10");

            //// Converter array em lista
            //int[] arrayParaConverter = { 1, 2, 3 };
            //List<int> listaDoArray = new List<int>(arrayParaConverter);

            ////Converter de lista para array
            //List<int> listaParaConverter = new List<int> { 4, 5, 6 };
            //int[] arrayDaLista = listaParaConverter.ToArray();

            #endregion

            #region ArrayLists
            //// Criar um ArrayList
            //ArrayList MyArrayList = new ArrayList();
            //MyArrayList.Add(1); // adicionar um elemento do tipo int
            //MyArrayList.Add("Sofia"); // adicionar um elemento do tipo string
            //MyArrayList.Add(12.69); // adicionar um elemento do tipo double
            //MyArrayList.Add(true); // adicionar um elemento do tipo booleano
            //MyArrayList.Add('A'); // adicionar um elemento do tipo char
            //MyArrayList.Add(new DateTime(2023,10,1)); // adicionar um elemento do tipo DateTime

            //foreach (var item in MyArrayList)
            //    Console.WriteLine($"Tipo: {item.GetType()}, Valor:{item}");

            //Console.WriteLine($"Números de elementos: {MyArrayList.Count}"); // Representa o número real de elemenos que estão na lista
            //Console.WriteLine($"Números de elementos: {MyArrayList.Capacity}"); // O espaço reservado na memória

            ////Remover um elemento da ArrayList
            //MyArrayList.RemoveAt(5);

            ////Remover um elemento específico
            //MyArrayList.Remove(true);

            ////Remover um range de elementos
            ////MyArrayList.RemoveRange(3, 2); //Remover os elementos a partir do indíce 3 por duas posições

            //// Limpar o arrayList
            ////MyArrayList.Clear();

            //ArrayList arrayList2 = new ArrayList();
            //arrayList2.Add(1);
            //arrayList2.Add(50);
            //arrayList2.Add(20);
            //arrayList2.Add(41);

            //arrayList2.Sort(); // Ordena os elementos do ArrayList se forem do mesmo tipo
            //                   // caso contrário resulta num InvalidOperationException


            //foreach (int v in arrayList2)
            //    Console.Write($"{v}");


            #endregion

            #region Dicionários
            // Criar um dicionário
            // Dictionary<TKey, TValue> nomeDicionario = new Dictionary<TKey, TValue> ();
            Dictionary<int, string> dicionarioLinguagens = new Dictionary<int, string>();

            dicionarioLinguagens.Add(1, "C#");
            dicionarioLinguagens.Add(2, "JAVA");
            dicionarioLinguagens.Add(3, "Python");
            dicionarioLinguagens.Add(4, "Ana");
            dicionarioLinguagens.Add(5, "Ruby");
            dicionarioLinguagens.Add(6, "PHP");
            dicionarioLinguagens.Add(7, "Cobol");

            //Mostrar o dicionário - com o recurso a var
            foreach (var element in dicionarioLinguagens)
                Console.WriteLine($"Chave: {element.Key}; Valor: {element.Value}");

            // Mostrar com recurso ao tipo de dado - struct KeyValuePair
            foreach (KeyValuePair<int, string> element in dicionarioLinguagens)
                Console.WriteLine($"Chave: {element.Key}; Valor: {element.Value}");

            // Remover um elemento do dicionário - elemento com a chave 3 neste caso
            dicionarioLinguagens.Remove(3);

            // Verificar se a chave existe no dicionário
            int chaveParaVerificar = 3;
            if (dicionarioLinguagens.ContainsKey(chaveParaVerificar))
                Console.WriteLine($"A chave {chaveParaVerificar} existe no dicionário e o valor associado é {dicionarioLinguagens[chaveParaVerificar]}");
            else
                Console.WriteLine($"A chave {chaveParaVerificar} não existe no dicionário");

            // Verificar se um valor existe no dicionário
            string valorParaVerificar = "Ruby";
            if (dicionarioLinguagens.ContainsValue(valorParaVerificar))
                Console.WriteLine($"O valor {valorParaVerificar} existe no dicionário.");
            else
                Console.WriteLine($"O valor {valorParaVerificar} não existe no dicionário.");

            // Verificar de forma eficiente se a chave existe e devolver o valor com segurança (sem exceções KeyNotFound)
            int chaveParaProcurar = 4;
            if (dicionarioLinguagens.TryGetValue(chaveParaProcurar, out string valor))
                Console.WriteLine($"O valor assocuiado à chave {chaveParaProcurar} é {valor}");
            else
                Console.WriteLine("Chave não encontrada!");

            // Limpar o dicionário
            // dicionarioLinguagens.Clear();

            // Console.WriteLine(dicionarioLinguagens.Where(v => v.Key == 5));
            Console.WriteLine(dicionarioLinguagens.Where(v => v.Key == 5).First());
            Console.WriteLine(dicionarioLinguagens.Where(v => v.Value.StartsWith("R", StringComparison.OrdinalIgnoreCase)).First());
            Console.WriteLine(dicionarioLinguagens.Where(v => v.Value.EndsWith("y", StringComparison.OrdinalIgnoreCase)).First());

            var resultado = dicionarioLinguagens.Where(v => v.Value.Contains("R"))
                                                .Select(v => v.Value)
                                                .ToList();

            Console.WriteLine("Valores que contêm a letra 'R': ");
            foreach (var item in resultado)
                Console.WriteLine(item);

            string nome = "Anabela";
            int numString = nome.Length;

            Console.WriteLine(nome.CompareTo("Anabela")); // 0 = igual ; < 0 = vem antes na ordem alfabética ; > 0 vem depois em ordem alfabética
            Console.WriteLine("Tamanho da string: " + numString);

            bool igual;
            igual = string.Equals("Anabela", "João");
            Console.WriteLine("Anabela é igual a João? " + igual);
            Console.WriteLine("Index de a : " + nome.LastIndexOf("a"));

            string nome2 = new string(nome.Reverse().ToArray());
            Console.WriteLine("String Original: " + nome + " String Invertida: " + nome2);

            var resultado2 = dicionarioLinguagens.Where(v => v.Value.IndexOf("a", StringComparison.OrdinalIgnoreCase) >= 0)
                                                 .Select(v => v.Value)
                                                 .ToList();

            foreach (var item in resultado2)
                Console.WriteLine(item);


            #endregion



        }
    }
}

