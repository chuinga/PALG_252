using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02_Loops
{
    internal class Program
    {
        /*
         2. Escreva um algoritmo que leia o código de um aluno (entre 1000 e 9999) e as suas três notas.
            Calcule a média ponderada do aluno, considerando que o peso para a maior 
            nota seja 4 e para as duas restantes, 3. Mostre o código do aluno, suas 
            três notas, a média calculada e uma mensagem “APROVADO” se a média for 
            maior ou igual a 10 e “REPROVADO” se a média for menor que 10.
        */

        static void Main(string[] args)
        {
            // Declaração das variáveis
            uint codigoAluno;
            float nota, nota1 = 0, nota2 = 0, nota3 = 0, media;


            // Pedir e validar o código do aluno - apenas entre 1000 e 9999
            do
            {
                Console.Write("Digite o código do aluno (4 dígitos): ");
            } while (!uint.TryParse(Console.ReadLine(), out codigoAluno) || codigoAluno < 1000 || codigoAluno > 9999);


            // Pedir e validar as notas
            for(int i = 1; i < 4; i++) {
                do
                {
                    Console.Write($"Digite a {i}ª nota do aluno: ");
                } while (!float.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 20);

                // Operador ternário para guardar em cada uma das variáveis das notas o seu respetivo valor
                float n = (i == 1) ? nota1 = nota : (i == 2 ? nota2 = nota : nota3 = nota);


            }


            // Cálculo da média ponderada – descobrir qual é a maior nota
            if (nota1 == nota2 && nota2 == nota3)
            {
                media = (nota1 * 4 + (nota2 + nota3) * 3) / 10;
            }
            else if (nota1 > nota2 && nota1 > nota3)
            {
                media = (nota1 * 4 + (nota2 + nota3) * 3) / 10;
            }
            else if (nota2 > nota1 && nota2 > nota3)
            {
                media = (nota2 * 4 + (nota1 + nota3) * 3) / 10;
            }
            else
            {
                media = (nota3 * 4 + (nota1 + nota2) * 3) / 10;
            }



            // Apresentar os resultados
            Console.WriteLine("\tCódigo do Aluno\tNota1\tNota2\tNota3");
            Console.WriteLine($"\t{codigoAluno}\t\t{nota1}\t{nota2}\t{nota3}");


            // Avaliar se a média é >= 10 ou não
            if (media >= 10)
                Console.WriteLine($"Média: {media:F2}\nSituação: APROVADO");
            else
                Console.WriteLine($"Média: {media:F2}\nSituação: REPROVADO");



        }
    }
}
