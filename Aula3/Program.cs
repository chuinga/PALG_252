using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3
{
    internal static class Program
    {        
        static void Main(string[] args)
        {
            // Tipos de variáveis
            // string - variável de texto (cadeia de caracteres) - pode conter letras, números e símbolos
            string nome; // declaração de variável
            nome = "Miguel"; // atribuição de valor

            // char - variável de um único caracter - letras, números ou símbolos - usa aspas simples
            char letra = 'A'; // declaração e atribuição de valor

            // variáveis numéricas
            // int - números inteiros (sem casas decimais)
            // byte (0 - 255) : 1 byte, sbyte, short, ushort, uint, long, ulong - outros tipos de inteiros com diferentes tamanhos e intervalos
            int numero = 123; // 4 bytes
            int limiteMax = int.MaxValue; // valor máximo que um int pode armazenar
            int limiteMin = int.MinValue; // valor mínimo que um int pode armazenar 

            uint uIntNumero = 156; // uint - números inteiros sem sinal (0 e positivos)
            uint ulimiteMax = uint.MaxValue;
            uint ulimiteMin = uint.MinValue;

            // Variáveis de ponto flutuante (números com casas decimais)
            // float, double, decimal
            // float - 4 bytes, precisão simples até 7 dígitos significativos
            // double - 8 bytes, precisão dupla até 15-16 dígitos significativos
            // decimal - 16 bytes, alta precisão, usado para valores monetários até 28-29 dígitos significativos
            double myDouble = 12.6978; // double é o tipo padrão para números com casas decimais
            int myIntDouble = (int)myDouble; // Cast explicito
            double myDouble2 = numero; // Cast implicito
            float myFloat = 12.69f; // o 'f' indica que é um float
            decimal myDecimal = 12.6978m; // o 'm' indica que é um decimal

            // bool - armazena valores lógicos: true (verdadeiro) ou false (falso)
            bool myBool = false;

            // arrays, lists, arrayList, dictionaries, enums - estruturas de dados mais complexas


            int idade;
            float preco;

            idade = int.Parse(Console.ReadLine()); 
            preco = float.Parse(Console.ReadLine());

            
            // Operadores aritméticos
            // + - * / %


        }
    }
}
