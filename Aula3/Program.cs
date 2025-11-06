using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos de variáveis
            // string - variável de texto (cadeia de caracteres) - pode conter letras, números e símbolos
            string nome; // declaração
            nome = "Maria"; // atribuição

            // char - armazena um único caracter - letra, simbolo, numero
            char caracter = 'A';

            // variáveis numéricas
            // int - numeros inteiros 
            // byte (0 - 255) : 1 byte, sbyte, short, ushort, uint, long, ulong : u for unsigned
            int numero = 123; // 4 bytes
            int limiteMax = int.MaxValue;
            int limiteMin = int.MinValue;

            uint uIntNumero = 156;
            uint ulimiteMax = uint.MaxValue;
            uint ulimiteMin = uint.MinValue;

            // Variáveis de ponto flutuante
            // float : 4 bytes, double, decimal : 16 bytes
            double myDouble = 12.69;
            int myIntDouble = (int)myDouble; // Cast Explicito
            double myDouble2 = numero; // Cast Implicito
            float myFloat = 156.98f;
            decimal myDecimal = 59.56m;

            // bool - armazenam valores do tipo true or false
            bool myBool = false;

            // arrays, lists, arrayList, dictionaries, enums - a dar ao longo da matéria


            //int idade;
            //float preco;
            //idade = int.Parse(Console.ReadLine());
            //preco = float.Parse(Console.ReadLine());

            // Operadores aritméticos
            // + - * / %

            //Incrementação / Decrementação
            // ++ / -- -> Incrementam/Decrementam o operador inteiro por 1

            //int num1, num2;
            //float soma, subtracao, divisao, multiplicacao, restoDivisao;

            //Console.Write("Escreve o primeiro número: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("Escreve o segundo número: ");
            //num2 = int.Parse(Console.ReadLine());

            //soma = num1 + num2;
            //subtracao = num1 - num2;
            //divisao = (float)num1 / num2;
            //multiplicacao = num1 * num2;
            //restoDivisao = num1 % num2;

            //Console.WriteLine($"{num1}+{num2}={soma}");
            //Console.WriteLine($"{num1}-{num2}={subtracao}");
            //Console.WriteLine($"{num1}/{num2}={divisao:0.00}"); // Valor decimal / float com duas casas decimais
            //Console.WriteLine($"{num1}*{num2}={multiplicacao:F2}"); // Ponto fixo com duas casas decimais
            //Console.WriteLine($"{num1}%{num2}={restoDivisao}");

            //Incrementar
            int myIntToIncrement = 9, myIntToIncrement2;
            //myIntToIncrement = myIntToIncrement + 1; // atribuir à variável myIntToIncrement o seu valor + 1
            //myIntToIncrement += 1; // atribuir à variável myIntToIncrement o seu valor + 1
            Console.WriteLine(myIntToIncrement);
            myIntToIncrement2 = myIntToIncrement++;  // atribuir à variável myIntToIncrement o seu valor + 1 - Incrementação com Pós-incremento
            Console.WriteLine($"Int1: {myIntToIncrement}, Int2: {myIntToIncrement2}");


            myIntToIncrement = 9;
            myIntToIncrement2 = 0;
            myIntToIncrement2 = ++myIntToIncrement; // Incrementação com pré-incremento
            Console.WriteLine($"Int1: {myIntToIncrement}, Int2: {myIntToIncrement2}");

            //Decrementar
            myIntToIncrement2 = myIntToIncrement--; // Decrementração com pós-decremento //Atribui primeiro o valor e depois decrementa
            Console.WriteLine($"Int1: {myIntToIncrement}, Int2: {myIntToIncrement2}"); 
            myIntToIncrement2 = --myIntToIncrement; // Decrementração com pré-decremento // Decrementa primeiro e depois atribui o valor
            Console.WriteLine($"Int1: {myIntToIncrement}, Int2: {myIntToIncrement2}");

            // Verdadeiro ou Falso
            bool myBool2;

            // Operadores relacionais 
            // > >= < <= == !=
            myBool2 = myIntToIncrement > myIntToIncrement2;
            Console.WriteLine(myBool2);

        }
    }
}
