using System;

namespace TrocaVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Exercício 1
            // Ler as quatro variáveis
            Console.Write("Digite o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            int D = int.Parse(Console.ReadLine());

            // Guardar temporariamente o valor de A
            int temp = A;

            // Fazer as trocas
            A = D;  // D passa para A
            D = C;  // C passa para D
            C = B;  // B passa para C
            B = temp; // A original passa para B

            // Mostrar os novos valores
            Console.WriteLine("\nApós a troca:");
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            Console.WriteLine($"C = {C}");
            Console.WriteLine($"D = {D}");
            */


            /*
            // Exercício 2
            // Ler as dimensões do retângulo
            Console.Write("Digite a base do retângulo: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            // Calcular a área
            double area = baseRetangulo * alturaRetangulo;

            // Mostrar o resultado
            Console.WriteLine($"\nA área do retângulo é: {area}");
            */

            /*
            // Exercício 3
            // Criar variáveis
            int numeroInteiro = 7;
            string textoNumero = "3";

            // Converter a string para número inteiro
            int numeroConvertido = Convert.ToInt32(textoNumero);

            // Somar os dois valores
            int resultado = numeroInteiro + numeroConvertido;

            // Mostrar o resultado
            Console.WriteLine($"A soma de {numeroInteiro} + {textoNumero} é = {resultado}");
            */

            /*
            // Exercício 4
            // Ler os valores de a, b, c e d
            Console.Write("Digite o valor de a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de d: ");
            double d = Convert.ToDouble(Console.ReadLine());

            // Calcular as expressões
            double exp1 = 3 * Math.Pow(c, 2) * (9 - 5);
            double exp2 = (2 * c + Math.Pow(b, 2)) / (3 * d);
            double exp3 = 2 * b;
            double exp4 = 3 * a * c * (25 + 6);

            // Mostrar os resultados
            Console.WriteLine("\nResultados das expressões:");
            Console.WriteLine($"1) 3c²(9 - 5)   = {exp1:F2}");
            Console.WriteLine($"2) (2c + b²)/3d = {exp2:F2}");
            Console.WriteLine($"3) 2b           = {exp3:F2}");
            Console.WriteLine($"4) 3ac(25 + 6)  = {exp4:F2}");
            */

            /*
            // Exercício 5
            // Ler as três notas do aluno
            Console.Write("Digite a primeira nota (peso 2): ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota (peso 3): ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota (peso 5): ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            // Calcular a média ponderada
            double mediaFinal = (nota1 * 2 + nota2 * 3 + nota3 * 5) / (2 + 3 + 5);

            // Mostrar o resultado
            Console.WriteLine($"\nA média final do aluno é: {mediaFinal:F2}");
            */

            /*
            // Exercício 6
            // Criar variáveis
            int numeroInt = 123456789;
            float numeroFloat;
            double numeroDouble;

            // Atribuir o int ao float
            numeroFloat = numeroInt;

            // Atribuir o float ao double
            numeroDouble = numeroFloat;

            // Mostrar os valores
            Console.WriteLine($"Valor original (int):   {numeroInt}");
            Console.WriteLine($"Valor após converter para float:  {numeroFloat}");
            Console.WriteLine($"Valor após converter para double: {numeroDouble}");

            // Observação sobre a precisão
            Console.WriteLine("\nComentário:");
            Console.WriteLine("O tipo 'float' tem cerca de 7 casas decimais de precisão.");
            Console.WriteLine("O tipo 'double' tem cerca de 15 a 16 casas decimais de precisão.");
            Console.WriteLine("Ao converter de int para float, há perda de precisão em números grandes, pois 'float' não consegue representar todos os dígitos.");
            Console.WriteLine("Converter de float para double não recupera essa precisão perdida, apenas mantém o valor aproximado do float.");
            */


            /*
            // Exercício 7
            // Ler o nome do produto
            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            // Ler o preço unitário
            Console.Write("Digite o preço unitário: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            // Criar a frase formatada
            string mensagem = $"O produto {nomeProduto} custa {preco:F2} euros.";

            // Mostrar o resultado
            Console.WriteLine("\n" + mensagem);
            */


            /*
            // Exercício 8
            // Ler o valor em euros
            Console.Write("Digite o valor em euros: ");
            double valorEuros = Convert.ToDouble(Console.ReadLine());

            // Taxa de câmbio aproximada (1 EUR = 1.156 USD)
            double taxaCambio = 1.156;

            // Converter para dólares
            double valorDolares = valorEuros * taxaCambio;

            // Mostrar o resultado
            Console.WriteLine($"\n{valorEuros:F2} EUR equivalem a {valorDolares:F2} USD.");
            */


            /*
            // Exercício 9
            // Ler o número
            Console.Write("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            // Calcular os resultados
            double vezes2 = numero * 2;
            double vezes3 = numero * 3;
            double vezes4 = numero * 4;

            // Mostrar os resultados
            Console.WriteLine($"\nO número multiplicado por 2 é: {vezes2}");
            Console.WriteLine($"O número multiplicado por 3 é: {vezes3}");
            Console.WriteLine($"O número multiplicado por 4 é: {vezes4}");
            */


            /*
            //  Exercício 10
            // Ler temperatura em Celsius
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Converter Celsius -> Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Converter Fahrenheit -> Celsius (reverso)
            double celsiusReverso = (fahrenheit - 32) * 5 / 9;

            // Mostrar os resultados
            Console.WriteLine($"\nTemperatura em Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Temperatura convertida novamente para Celsius: {celsiusReverso:F2} °C");
            */


            /*
            // Exercício 11
            // Ler o ano de nascimento
            Console.Write("Digite o ano de nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            // Obter o ano atual do sistema
            int anoAtual = DateTime.Now.Year;

            // Calcular a idade
            int idade = anoAtual - anoNascimento;

            // Mostrar o resultado
            Console.WriteLine($"\nA idade dessa pessoa é: {idade} anos.");
            */


            /*
            // Exercício 12
            // Ler o preço do produto
            Console.Write("Digite o preço do produto (em euros): ");
            double preco = Convert.ToDouble(Console.ReadLine());

            // Calcular o imposto (40%)
            double taxa = 0.40;
            double imposto = preco * taxa;

            // Calcular o preço total (produto + imposto)
            double total = preco + imposto;

            // Mostrar os resultados
            Console.WriteLine($"\nValor do imposto (40%): {imposto:F2} €");
            Console.WriteLine($"Preço total a pagar: {total:F2} €");
            */


            /*
            // Exercício 13
            // Ler o tempo total em segundos
            Console.Write("Digite o tempo de duração do evento (em segundos): ");
            int totalSegundos = Convert.ToInt32(Console.ReadLine());

            // Calcular horas, minutos e segundos
            int horas = totalSegundos / 3600;              // 1 hora = 3600 segundos
            int minutos = (totalSegundos % 3600) / 60;     // resto dividido por 60 dá os minutos
            int segundos = totalSegundos % 60;             // resto final são os segundos

            // Mostrar o resultado formatado
            Console.WriteLine($"\nDuração do evento: {horas}h {minutos}m {segundos}s");
            */


            /*
            // Exercício 14
            // Ler o nome da pessoa
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            // Ler a idade em anos
            Console.Write("Digite a idade da pessoa (em anos): ");
            int idade = Convert.ToInt32(Console.ReadLine());

            // Calcular o total de dias vividos (anos completos)
            int diasVividos = idade * 365;

            // Mostrar o resultado
            Console.WriteLine($"\nO {nome} já viveu aproximadamente {diasVividos} dias.");
            */


            /*
            // Exercício 15
            Console.WriteLine("a) a > b");
            Console.Write("Digite o valor de a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {a > b}\n");

            Console.WriteLine("b) x + y == 100");
            Console.Write("Digite o valor de x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {x + y == 100}\n");

            Console.WriteLine("c) n1 + n2 + n3 > 100");
            Console.Write("Digite o valor de n1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de n2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de n3: ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {n1 + n2 + n3 > 100}\n");

            Console.WriteLine("d) m é múltiplo de n");
            Console.Write("Digite o valor de m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Resultado: {m % n == 0}\n");

            Console.WriteLine("e) idade entre 18 e 65 (inclusive)");
            Console.Write("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Resultado: {idade >= 18 && idade <= 65}\n");

            Console.WriteLine("f) nota fora do intervalo [0,20]");
            Console.Write("Digite a nota: ");
            double nota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {nota < 0 || nota > 20}\n");

            Console.WriteLine("g) x é positivo e menor que 10");
            Console.Write("Digite o valor de x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {x > 0 && x < 10}\n");

            Console.WriteLine("h) pelo menos um entre a e b é negativo");
            Console.Write("Digite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {a < 0 || b < 0}\n");

            Console.WriteLine("i) p é o maior entre p, q e r");
            Console.Write("Digite o valor de p: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de q: ");
            double q = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {p > q && p > r}\n");

            Console.WriteLine("j) num é par");
            Console.Write("Digite o número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Resultado: {num % 2 == 0}\n");

            Console.WriteLine("k) altura é o dobro (ou mais) da largura");
            Console.Write("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {altura >= 2 * largura}\n");

            Console.WriteLine("l) A / B > 10");
            Console.Write("Digite o valor de A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {A / B > 10}\n");

            Console.WriteLine("m) média de a, b e c >= 50");
            Console.Write("Digite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {(a + b + c) / 3 >= 50}\n");

            Console.WriteLine("n) x e y fora do intervalo [0,10]");
            Console.Write("Digite o valor de x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {(x < 0 || x > 10) && (y < 0 || y > 10)}\n");

            Console.WriteLine("o) a + b == c + d");
            Console.Write("Digite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de d: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {a + b == c + d}\n");
            */


            /*
            // Exercício 16
            // Ler o valor em euros que o motorista quer colocar
            Console.Write("Digite o valor em euros que deseja colocar: ");
            double valorPago = Convert.ToDouble(Console.ReadLine());

            // Ler o preço por litro da gasolina
            Console.Write("Digite o preço por litro da gasolina: ");
            double precoPorLitro = Convert.ToDouble(Console.ReadLine());

            // Calcular a quantidade de litros
            double litros = valorPago / precoPorLitro;

            // Mostrar o resultado
            Console.WriteLine($"\nCom {valorPago:F2} Euros, o motorista conseguiu colocar {litros:F2} litros de gasolina.");
            */


            
            // Exercício 17
            // Preços por quilo
            const double precoBanana = 1.20;
            const double precoMaca = 1.50;

            // Ler quantidades vendidas
            Console.Write("Digite a quantidade de bananas vendidas (em kg): ");
            double kgBananas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de maçãs vendidas (em kg): ");
            double kgMacas = Convert.ToDouble(Console.ReadLine());

            // Calcular faturação
            double totalBananas = kgBananas * precoBanana;
            double totalMacas = kgMacas * precoMaca;
            double totalFaturado = totalBananas + totalMacas;

            // Calcular valor a guardar (10% do total)
            double poupanca = totalFaturado * 0.10;

            // Mostrar resultados
            Console.WriteLine("\n===== Resumo do Dia =====");
            Console.WriteLine($"Total faturado com bananas: {totalBananas:F2} €");
            Console.WriteLine($"Total faturado com maçãs:   {totalMacas:F2} €");
            Console.WriteLine($"Total faturado no dia:      {totalFaturado:F2} €");
            Console.WriteLine($"Valor a guardar (10%):      {poupanca:F2} €");
            
        }
    }
}
