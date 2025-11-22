using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Seleção de plano de subscrição com regras especiais
            string plano = "";
            int idade = 0;

            // Ler plano com validação
            while (true)
            {
                Console.Write("Escolha o plano (Básico, Plus, Premium): ");
                plano = Console.ReadLine().Trim().ToLower();

                if (plano == "básico" || plano == "basico" || plano == "plus" || plano == "premium")
                {
                    break;
                }

                Console.WriteLine("Plano inválido! Tente novamente.");
            }

            // Ler idade com validação
            while (true)
            {
                Console.Write("Indique a sua idade: ");

                if (int.TryParse(Console.ReadLine(), out idade) && idade >= 0)
                {
                    break;
                }

                Console.WriteLine("Idade inválida! Introduza um número inteiro válido.");
            }

            // Regras especiais
            if (idade < 18)
            {
                plano = "básico";
                Console.WriteLine("\nMenor de idade. Plano ajustado automaticamente para Básico.");
            }

            // Determinar preço base
            double preco = 0;

            if (plano == "básico" || plano == "basico")
            {
                preco = 10;
            }
            else if (plano == "plus")
            {
                preco = 20;
            }
            else if (plano == "premium")
            {
                preco = 30;
            }

            // Desconto 65+
            if (idade >= 65)
            {
                preco = preco * 0.8;
                Console.WriteLine("Desconto de 20% aplicado por ter 65 anos ou mais.");
            }

            Console.WriteLine($"\nPlano final: {plano}");
            Console.WriteLine($"Preço final: {preco:F2}€");


            // 2. Configuração automática de perfil de utilizador



        }
    }
}
