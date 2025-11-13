using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaQualitativa
{
    internal class Program
    {
        /*
         *     Escreva um programa que mediante a entrada de uma nota entre
         * 0 e 20 valores indique a respetiva classificação qualitativa usando a seguinte tabela:
         *
         *     Nota Quantitativa        Nota Qualitativa
         *     Entre 0 e 6 (exclusivo)  Fraco
         *     Entre 6 e 10 (exclusivo) Insuficiente
         *     Entre 10 e 15 (exclusivo) Satisfaz
         *     Entre 15 e 18 (exclusivo) Bom
         *     Entre 18 e 20            Muito Bom
         *
         * Para qualquer outro valor deverá aparecer uma mensagem a avisar que não é uma nota válida.
         */

        static void Main(string[] args)
        {
            float nota;

            inicio:

            Console.Write("Indique a sua nota: ");

            if (float.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 20)
            {
                if (nota >= 18)
                    Console.WriteLine("Muito Bom!");
                else if (nota >= 15)
                    Console.WriteLine("Bom!");
                else if (nota >= 10)
                    Console.WriteLine("Satisfaz!");
                else if (nota >= 6)
                    Console.WriteLine("Insuficiente!");
                else
                    Console.WriteLine("Fraco!");
            }
            else
            {
                Console.WriteLine("Entrada inválida!");
            }

            goto inicio;

        }
    }
}
