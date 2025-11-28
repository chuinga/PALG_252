using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercAlturas
{
    internal class Program
    {
        // O João tem 1,50 metros e cresce 2 centímetros por ano, enquanto o
        // Zé tem 1,10 metros e cresce 3 centímetros por ano. Construa um algoritmo
        // que calcule e mostre quantos anos serão necessários para que Zé seja maior que João.

        static void Main(string[] args)
        {
            int anos = 0;

            for (int j = 150, z = 110; z <= j; j = j + 2, z = z + 3)
            {
                Console.WriteLine($"Altura do João: {j} Altura do Zé: {z}");
                anos++;
            }

            Console.WriteLine($"O Zé precisa de {anos} para ser maior que o João");
        }
    }
}
