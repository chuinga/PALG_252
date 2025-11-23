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
            //// 1. Seleção de plano de subscrição com regras especiais
            //string plano = "";
            //int idade = 0;

            //// Ler plano com validação
            //bool planoValido = false;
            //while (!planoValido)
            //{
            //    Console.Write("Escolha o plano (Básico, Plus, Premium): ");
            //    plano = Console.ReadLine().Trim().ToLower();
            //    if (plano == "básico" || plano == "basico" || plano == "plus" || plano == "premium")
            //    {
            //        planoValido = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Plano inválido! Tente novamente.");
            //    }
            //}

            //// Ler idade com validação
            //bool idadeValida = false;
            //while (!idadeValida)
            //{
            //    Console.Write("Indique a sua idade: ");
            //    if (int.TryParse(Console.ReadLine(), out idade) && idade >= 0)
            //    {
            //        idadeValida = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Idade inválida! Introduza um número inteiro válido.");
            //    }
            //}

            //// Regras especiais
            //if (idade < 18)
            //{
            //    plano = "básico";
            //    Console.WriteLine("\nMenor de idade. Plano ajustado automaticamente para Básico.");
            //}

            //// Determinar preço base
            //double preco = 0;
            //if (plano == "básico" || plano == "basico")
            //{
            //    preco = 10;
            //}
            //else if (plano == "plus")
            //{
            //    preco = 20;
            //}
            //else if (plano == "premium")
            //{
            //    preco = 30;
            //}

            //// Desconto 65+
            //if (idade >= 65)
            //{
            //    preco = preco * 0.8;
            //    Console.WriteLine("Desconto de 20% aplicado por ter 65 anos ou mais.");
            //}

            //Console.WriteLine($"\nPlano final: {plano}");
            //Console.WriteLine($"Preço final: {preco:F2}€");


            //// 2. Configuração automática de perfil de utilizador
            //string nome = "";
            //int idade = 0;
            //string pais = "";
            //string idioma = "";
            //string acesso = "";
            //string tema = "";

            //// Ler nome com validação
            //bool nomeValido = false;
            //while (!nomeValido)
            //{
            //    Console.Write("Indique o seu nome: ");
            //    nome = Console.ReadLine().Trim();
            //    if (!string.IsNullOrEmpty(nome))
            //        nomeValido = true;
            //    else
            //        Console.WriteLine("Nome inválido. Tente novamente.\n");
            //}

            //// Ler idade com validação
            //bool idadeValida = false;
            //while (!idadeValida)
            //{
            //    Console.Write("Indique a sua idade: ");
            //    if (int.TryParse(Console.ReadLine(), out idade) && idade >= 0)
            //        idadeValida = true;
            //    else
            //        Console.WriteLine("Idade inválida. Introduza um número inteiro positivo.\n");
            //}

            //// Ler país com validação (PT, BR, ES)
            //bool paisValido = false;
            //while (!paisValido)
            //{
            //    Console.Write("Indique o país (PT, BR ou ES): ");
            //    pais = Console.ReadLine().Trim().ToUpper();
            //    if (pais == "PT" || pais == "BR" || pais == "ES")
            //    {
            //        paisValido = true;

            //        // Definir idioma com base no país
            //        if (pais == "PT")
            //            idioma = "Português";
            //        else if (pais == "BR")
            //            idioma = "Português (BR)";
            //        else if (pais == "ES")
            //            idioma = "Espanhol";
            //    }
            //    else
            //    {
            //        Console.WriteLine("País inválido. Use apenas PT, BR ou ES.\n");
            //    }
            //}

            //// Definir nível de acesso
            //if (idade < 18)
            //    acesso = "Limitado";
            //else if (idade <= 50)
            //    acesso = "Total";
            //else
            //    acesso = "Total (tema escuro)";

            //// Definir tema (claro ou escuro)
            //if (idade > 50 || pais != "BR")
            //    tema = "Escuro";
            //else
            //    tema = "Claro";

            //// Mostrar resumo da configuração
            //Console.WriteLine("\n--- Perfil de Utilizador ---");
            //Console.WriteLine($"Nome   : {nome}");
            //Console.WriteLine($"Idade  : {idade}");
            //Console.WriteLine($"País   : {pais}");
            //Console.WriteLine($"Idioma : {idioma}");
            //Console.WriteLine($"Acesso : {acesso}");
            //Console.WriteLine($"Tema   : {tema}");


            //// 3. Sistema de prioridade hospitalar
            //int idade;
            //int prioridadeSintoma = 0;
            //int prioridadeFinal;
            //string sintoma = "";
            //string estadoGeral = "";
            //int ajusteEstado = 0;

            //// Ler idade
            //while (true)
            //{
            //    Console.Write("Indique a sua idade: ");
            //    if (int.TryParse(Console.ReadLine(), out idade) && idade >= 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Idade inválida. Introduza um número inteiro positivo.\n");
            //}

            //// Ler sintoma principal
            //while (true)
            //{
            //    Console.WriteLine("\nSintoma principal:");
            //    Console.WriteLine("1 - Dor");
            //    Console.WriteLine("2 - Febre");
            //    Console.WriteLine("3 - Queda");
            //    Console.WriteLine("4 - Dificuldade de respiração");
            //    Console.Write("Escolha (1-4): ");

            //    string opcaoSintoma = Console.ReadLine().Trim();

            //    switch (opcaoSintoma)
            //    {
            //        case "1":
            //            sintoma = "dor";
            //            prioridadeSintoma = 2; // média
            //            break;
            //        case "2":
            //            sintoma = "febre";
            //            prioridadeSintoma = 1; // baixa
            //            break;
            //        case "3":
            //            sintoma = "queda";
            //            prioridadeSintoma = 3; // alta
            //            break;
            //        case "4":
            //            sintoma = "dificuldade de respiração";
            //            prioridadeSintoma = 3; // alta
            //            break;
            //        default:
            //            Console.WriteLine("Opção inválida, tente novamente.\n");
            //            continue;
            //    }

            //    break;
            //}

            //// Ler estado geral
            //while (true)
            //{
            //    Console.WriteLine("\nEstado geral:");
            //    Console.WriteLine("1 - Leve");
            //    Console.WriteLine("2 - Moderado");
            //    Console.WriteLine("3 - Grave");
            //    Console.Write("Escolha (1-3): ");

            //    string opcaoEstado = Console.ReadLine().Trim();

            //    switch (opcaoEstado)
            //    {
            //        case "1":
            //            estadoGeral = "leve";
            //            ajusteEstado = 0;
            //            break;
            //        case "2":
            //            estadoGeral = "moderado";
            //            ajusteEstado = 1;
            //            break;
            //        case "3":
            //            estadoGeral = "grave";
            //            ajusteEstado = 2;
            //            break;
            //        default:
            //            Console.WriteLine("Opção inválida, tente novamente.\n");
            //            continue;
            //    }

            //    break;
            //}

            //// Calcular prioridade final
            //prioridadeFinal = prioridadeSintoma;

            //if (idade >= 65)
            //{
            //    prioridadeFinal++;
            //}

            //prioridadeFinal += ajusteEstado;

            //if (prioridadeFinal < 1) prioridadeFinal = 1;
            //if (prioridadeFinal > 4) prioridadeFinal = 4;

            //string prioridadeTexto;

            //switch (prioridadeFinal)
            //{
            //    case 1: prioridadeTexto = "Baixa"; break;
            //    case 2: prioridadeTexto = "Média"; break;
            //    case 3: prioridadeTexto = "Alta"; break;
            //    default: prioridadeTexto = "Muito Alta"; break;
            //}

            //Console.WriteLine("\n--- Resultado da Triagem ---");
            //Console.WriteLine($"Idade          : {idade}");
            //Console.WriteLine($"Sintoma        : {sintoma}");
            //Console.WriteLine($"Estado geral   : {estadoGeral}");
            //Console.WriteLine($"Prioridade final: {prioridadeTexto}");


            //// 4. Simulador de custo de viagem
            //string destino = "";
            //string classe = "";
            //int idade = 0;
            //double tarifaBase = 0;
            //double precoFinal;

            //// Ler destino
            //bool destinoValido = false;
            //while (!destinoValido)
            //{
            //    Console.Write("Destino (Paris, Londres ou Roma): ");
            //    destino = Console.ReadLine().Trim().ToLower();
            //    if (destino == "paris" || destino == "londres" || destino == "roma")
            //    {
            //        if (destino == "paris") tarifaBase = 120;
            //        if (destino == "londres") tarifaBase = 150;
            //        if (destino == "roma") tarifaBase = 100;
            //        destinoValido = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Destino inválido. Tente novamente.\n");
            //    }
            //}

            //// Ler classe de voo
            //bool classeValida = false;
            //while (!classeValida)
            //{
            //    Console.Write("Classe (economy, business ou first): ");
            //    classe = Console.ReadLine().Trim().ToLower();
            //    if (classe == "economy" || classe == "business" || classe == "first")
            //    {
            //        classeValida = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Classe inválida. Tente novamente.\n");
            //    }
            //}

            //// Ler idade
            //bool idadeValida = false;
            //while (!idadeValida)
            //{
            //    Console.Write("Indique a sua idade: ");
            //    if (int.TryParse(Console.ReadLine(), out idade) && idade >= 0)
            //    {
            //        idadeValida = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Idade inválida. Introduza um número inteiro positivo.\n");
            //    }
            //}

            //// Calcular preço base
            //precoFinal = tarifaBase;

            //// Extra para classe first
            //if (classe == "first")
            //{
            //    precoFinal += 50;
            //}

            //// Aplicar descontos
            //if (idade < 12)
            //{
            //    precoFinal *= 0.5; // 50%
            //}
            //else if (idade >= 65)
            //{
            //    precoFinal *= 0.85; // 15% desconto
            //}

            //// Perguntar se é militar
            //Console.Write("É militar? (s/n): ");
            //string militar = Console.ReadLine().Trim().ToLower();
            //if (militar == "s" || militar == "sim")
            //{
            //    precoFinal *= 0.90; // 10% desconto
            //}

            //// Mostrar resultado
            //Console.WriteLine("\n--- Resumo da Viagem ---");
            //Console.WriteLine($"Destino: {destino}");
            //Console.WriteLine($"Classe: {classe}");
            //Console.WriteLine($"Idade: {idade}");
            //Console.WriteLine($"Preço final: {precoFinal:F2}€");


            //// 5.Análise avançada de número
            //int numero = 0;

            //// Ler e validar o número
            //bool numeroValido = false;
            //while (!numeroValido)
            //{
            //    Console.Write("Indique um número: ");
            //    if (int.TryParse(Console.ReadLine(), out numero))
            //    {
            //        numeroValido = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Entrada inválida. Introduza um número inteiro.\n");
            //    }
            //}

            //// Classificar o número
            //Console.WriteLine("\n--- Análise do Número ---");

            //string classificacao = "";
            //if (numero < -100)
            //{
            //    classificacao = "muito negativo";
            //}
            //else if (numero >= -100 && numero <= -1)
            //{
            //    classificacao = "negativo";
            //}
            //else if (numero == 0)
            //{
            //    classificacao = "zero";
            //}
            //else if (numero >= 1 && numero <= 100)
            //{
            //    classificacao = "positivo";
            //}
            //else // numero > 100
            //{
            //    classificacao = "muito positivo";
            //}

            //Console.WriteLine($"O número {numero} é classificado como: {classificacao}");

            //// Verificar se está dentro do intervalo 10-50
            //if (numero >= 10 && numero <= 50)
            //{
            //    Console.WriteLine($"O número {numero} está DENTRO do intervalo [10-50]");
            //}
            //else
            //{
            //    Console.WriteLine($"O número {numero} está FORA do intervalo [10-50]");
            //}


            //// 6. Sistema de faturação simplificado
            //string tipoCliente = "";
            //double montante = 0;
            //double taxaImposto = 0;
            //double montanteFinal;

            //// Ler e validar tipo de cliente
            //bool tipoValido = false;
            //while (!tipoValido)
            //{
            //    Console.Write("Tipo de cliente (particular, empresa ou ONG): ");
            //    tipoCliente = Console.ReadLine().Trim().ToLower();
            //    if (tipoCliente == "particular" || tipoCliente == "empresa" || tipoCliente == "ong")
            //    {
            //        tipoValido = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tipo de cliente inválido. Tente novamente.\n");
            //    }
            //}

            //// Ler e validar montante
            //bool montanteValido = false;
            //while (!montanteValido)
            //{
            //    Console.Write("Montante da fatura (€): ");
            //    if (double.TryParse(Console.ReadLine(), out montante) && montante >= 0)
            //    {
            //        montanteValido = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Montante inválido. Introduza um valor numérico positivo.\n");
            //    }
            //}

            //// Definir taxa de imposto baseada no tipo de cliente
            //if (tipoCliente == "particular")
            //{
            //    taxaImposto = 0.23; // 23%
            //}
            //else if (tipoCliente == "empresa")
            //{
            //    taxaImposto = 0.15; // 15%
            //}
            //else if (tipoCliente == "ong")
            //{
            //    taxaImposto = 0.0; // 0%
            //}

            //// Calcular montante base
            //montanteFinal = montante;

            //// Aplicar imposto apenas se montante > 0
            //if (montante > 0)
            //{
            //    montanteFinal = montante + (montante * taxaImposto);
            //}

            //// Aplicar ajustes específicos
            //if (tipoCliente == "empresa" && montante > 1000)
            //{
            //    // Desconto de 5% no montante antes do imposto
            //    double desconto = montante * 0.05;
            //    montanteFinal -= desconto;
            //    Console.WriteLine($"\nDesconto aplicado (5%): {desconto:F2}€");
            //}
            //else if (tipoCliente == "ong")
            //{
            //    // Isenção adicional de 10%
            //    double isencao = montante * 0.10;
            //    montanteFinal -= isencao;
            //    Console.WriteLine($"\nIsenção adicional aplicada (10%): {isencao:F2}€");
            //}

            //// Mostrar resultado
            //Console.WriteLine("\n--- Resumo da Fatura ---");
            //Console.WriteLine($"Tipo de cliente: {tipoCliente}");
            //Console.WriteLine($"Montante base: {montante:F2}€");
            //Console.WriteLine($"Taxa de imposto: {taxaImposto * 100}%");
            //Console.WriteLine($"Montante final: {montanteFinal:F2}€");



            //// 7. Classificador de notas com regras alternativas
            //int nota = 0;
            //string classificacao = "";

            //// Ler e validar a nota
            //bool notaValida = false;
            //while (!notaValida)
            //{
            //    Console.Write("Indique uma nota (0-100): ");
            //    if (int.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 100)
            //    {
            //        notaValida = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nota inválida. Introduza um valor entre 0 e 100.\n");
            //    }
            //}

            //// Classificar a nota
            //if (nota >= 90 && nota <= 100)
            //{
            //    classificacao = "A";
            //}
            //else if (nota >= 80 && nota <= 89)
            //{
            //    classificacao = "B";
            //}
            //else if (nota >= 70 && nota <= 79)
            //{
            //    classificacao = "C";
            //}
            //else if (nota >= 50 && nota <= 69)
            //{
            //    classificacao = "D";
            //}
            //else // nota < 50
            //{
            //    classificacao = "F";
            //}

            //// Mostrar resultado
            //Console.WriteLine("\n--- Análise da Nota ---");
            //Console.WriteLine($"Nota: {nota}");
            //Console.WriteLine($"Classificação: {classificacao}");

            //// Verificar se está acima ou abaixo da média
            //if (nota >= 50)
            //{
            //    Console.WriteLine("Situação: Acima da média (>=50)");
            //}
            //else
            //{
            //    Console.WriteLine("Situação: Abaixo da média (<50)");
            //}

            //// Verificar reprovação imediata
            //if (nota < 40)
            //{
            //    Console.WriteLine("REPROVAÇÃO IMEDIATA (nota inferior a 40)");
            //}


            //// 8. Simulador de escolha de arma (jogo)
            //string classe = "";
            //string atributo = "";
            //string arma = "";
            //string tipoArma = "";

            //// Ler e validar classe
            //bool classeValida = false;
            //while (!classeValida)
            //{
            //    Console.Write("Indique a classe do personagem (guerreiro, mago ou arqueiro): ");
            //    classe = Console.ReadLine().Trim().ToLower();
            //    if (classe == "guerreiro" || classe == "mago" || classe == "arqueiro")
            //        classeValida = true;
            //    else
            //        Console.WriteLine("Classe inválida. Tente novamente.\n");
            //}

            //// Ler e validar atributo principal
            //bool atributoValido = false;
            //while (!atributoValido)
            //{
            //    Console.Write("Indique o atributo principal (força, inteligência ou agilidade): ");
            //    atributo = Console.ReadLine().Trim().ToLower();
            //    if (atributo == "força" || atributo == "forca" || atributo == "inteligência" || atributo == "inteligencia" || atributo == "agilidade")
            //        atributoValido = true;
            //    else
            //        Console.WriteLine("Atributo inválido. Tente novamente.\n");
            //}

            //// Normalizar atributo (remover acentos para facilitar comparação)
            //if (atributo == "força")
            //    atributo = "forca";
            //if (atributo == "inteligência")
            //    atributo = "inteligencia";

            //// Determinar arma recomendada
            //if (classe == "guerreiro")
            //{
            //    if (atributo == "forca")
            //    {
            //        arma = "Espada";
            //        tipoArma = "pesada";
            //    }
            //    else if (atributo == "agilidade")
            //    {
            //        arma = "Machado";
            //        tipoArma = "leve";
            //    }
            //    else
            //    {
            //        arma = "Marreta";
            //        tipoArma = "raw power";
            //    }
            //}
            //else if (classe == "mago")
            //{
            //    if (atributo == "inteligencia")
            //    {
            //        arma = "Bastão";
            //        tipoArma = "leve";
            //    }
            //    else if (atributo == "forca")
            //    {
            //        arma = "Orbe";
            //        tipoArma = "pesado";
            //    }
            //    else
            //    {
            //        arma = "Cajado";
            //        tipoArma = "raw power";
            //    }
            //}
            //else if (classe == "arqueiro")
            //{
            //    if (atributo == "agilidade")
            //    {
            //        arma = "Arco";
            //        tipoArma = "leve";
            //    }
            //    else if (atributo == "forca")
            //    {
            //        arma = "Besta";
            //        tipoArma = "pesada";
            //    }
            //    else
            //    {
            //        arma = "Lança";
            //        tipoArma = "raw power";
            //    }
            //}

            //// Mostrar resultado
            //Console.WriteLine("\n--- Escolha de Arma ---");
            //Console.WriteLine($"Classe: {classe}");
            //Console.WriteLine($"Atributo principal: {atributo}");
            //Console.WriteLine($"Arma recomendada: {arma} ({tipoArma})");


            //// 9. Sistema de menu de restaurante com personalização
            //string pratosPrincipal = "";
            //string acompanhamento = "";
            //string bebida = "";

            //// Ler e validar prato principal
            //bool pratoValido = false;
            //while (!pratoValido)
            //{
            //    Console.Write("Escolha o prato principal (pizza, sushi ou salada): ");
            //    pratosPrincipal = Console.ReadLine().Trim().ToLower();
            //    if (pratosPrincipal == "pizza" || pratosPrincipal == "sushi" || pratosPrincipal == "salada")
            //        pratoValido = true;
            //    else
            //        Console.WriteLine("Prato inválido. Tente novamente.\n");
            //}

            //// Ler e validar acompanhamento
            //bool acompanhamentoValido = false;
            //while (!acompanhamentoValido)
            //{
            //    Console.Write("Escolha o acompanhamento (batata, arroz ou legumes): ");
            //    acompanhamento = Console.ReadLine().Trim().ToLower();
            //    if (acompanhamento == "batata" || acompanhamento == "arroz" || acompanhamento == "legumes")
            //        acompanhamentoValido = true;
            //    else
            //        Console.WriteLine("Acompanhamento inválido. Tente novamente.\n");
            //}

            //// Ler e validar bebida
            //bool bebidaValida = false;
            //while (!bebidaValida)
            //{
            //    Console.Write("Escolha a bebida (sumo, água ou vinho): ");
            //    bebida = Console.ReadLine().Trim().ToLower();
            //    if (bebida == "sumo" || bebida == "água" || bebida == "agua" || bebida == "vinho")
            //        bebidaValida = true;
            //    else
            //        Console.WriteLine("Bebida inválida. Tente novamente.\n");
            //}

            //// Normalizar bebida (remover acento)
            //if (bebida == "água")
            //    bebida = "agua";

            //// Verificar combinações inválidas
            //bool combinacaoInvalida = false;

            //if (pratosPrincipal == "sushi" && acompanhamento == "batata")
            //    combinacaoInvalida = true;
            //else if (pratosPrincipal == "pizza" && acompanhamento == "arroz")
            //    combinacaoInvalida = true;
            //else if (pratosPrincipal == "salada" && acompanhamento == "legumes")
            //    combinacaoInvalida = true;

            //// Mostrar resultado
            //Console.WriteLine("\n--- Resumo do Pedido ---");
            //Console.WriteLine($"Prato principal: {pratosPrincipal}");
            //Console.WriteLine($"Acompanhamento: {acompanhamento}");
            //Console.WriteLine($"Bebida: {bebida}");

            //if (combinacaoInvalida)
            //{
            //    Console.WriteLine("\nERRO: Combinação inválida!");
            //    Console.WriteLine("Combinações não permitidas:");
            //    Console.WriteLine("  - Sushi + Batata");
            //    Console.WriteLine("  - Pizza + Arroz");
            //    Console.WriteLine("  - Salada + Legumes");
            //}
            //else
            //{
            //    Console.WriteLine("\nCombinação válida!");
            //    Console.WriteLine("A sua refeição inclui sobremesa grátis!");
            //}


            //// 10. Configurador de computador
            //string categoria = "";
            //double orcamento = 0;
            //double precoMinimo = 0;
            //double precoMaximo = 0;

            //// Ler e validar categoria
            //bool categoriaValida = false;
            //while (!categoriaValida)
            //{
            //    Console.Write("Indique a categoria do computador (gaming, workstation ou básico): ");
            //    categoria = Console.ReadLine().Trim().ToLower();
            //    if (categoria == "gaming" || categoria == "workstation" || categoria == "básico" || categoria == "basico")
            //        categoriaValida = true;
            //    else
            //        Console.WriteLine("Categoria inválida. Tente novamente.\n");
            //}

            //// Normalizar categoria (remover acento)
            //if (categoria == "básico")
            //    categoria = "basico";

            //// Ler e validar orçamento
            //bool orcamentoValido = false;
            //while (!orcamentoValido)
            //{
            //    Console.Write("Indique o orçamento disponível (€): ");
            //    if (double.TryParse(Console.ReadLine(), out orcamento) && orcamento > 0)
            //        orcamentoValido = true;
            //    else
            //        Console.WriteLine("Orçamento inválido. Introduza um valor positivo.\n");
            //}

            //// Definir preços mínimo e máximo por categoria
            //if (categoria == "gaming")
            //{
            //    precoMinimo = 1000;
            //    precoMaximo = 3000;
            //}
            //else if (categoria == "workstation")
            //{
            //    precoMinimo = 800;
            //    precoMaximo = 2500;
            //}
            //else if (categoria == "basico")
            //{
            //    precoMinimo = 400;
            //    precoMaximo = 1000;
            //}

            //// Mostrar resultado
            //Console.WriteLine("\n--- Configurador de Computador ---");
            //Console.WriteLine($"Categoria: {categoria}");
            //Console.WriteLine($"Orçamento: {orcamento:F2}€");
            //Console.WriteLine($"Intervalo de preços: {precoMinimo:F2}€ - {precoMaximo:F2}€");

            //// Verificar orçamento e dar recomendação
            //if (orcamento < precoMinimo)
            //{
            //    Console.WriteLine("\nOrçamento insuficiente!");
            //    Console.WriteLine($"Recomendação: Reduzir especificações ou aumentar orçamento em {precoMinimo - orcamento:F2}€");
            //    Console.WriteLine("Ação recomendada: REDUÇÃO DE CUSTOS");
            //}
            //else if (orcamento > precoMaximo)
            //{
            //    Console.WriteLine("\nOrçamento acima do máximo!");
            //    Console.WriteLine($"Recomendação: Considere um upgrade para melhor desempenho (sobra: {orcamento - precoMaximo:F2}€)");
            //    Console.WriteLine("Ação recomendada: UPGRADE");
            //}
            //else
            //{
            //    Console.WriteLine("\nOrçamento adequado!");
            //    Console.WriteLine("Recomendação: Configuração ideal dentro do intervalo de preços");
            //    Console.WriteLine("Ação recomendada: Configuração padrão adequada");
            //}


            //// 11. Sistema de recomendação musical
            //string humor = "";
            //int hora = 0;
            //string tipoPlaylist = "";
            //string intensidade = "";

            //// Ler e validar humor
            //bool humorValido = false;
            //while (!humorValido)
            //{
            //    Console.Write("Indique o seu humor (feliz, neutro ou triste): ");
            //    humor = Console.ReadLine().Trim().ToLower();
            //    if (humor == "feliz" || humor == "neutro" || humor == "triste")
            //        humorValido = true;
            //    else
            //        Console.WriteLine("Humor inválido. Tente novamente.\n");
            //}

            //// Ler e validar hora do dia
            //bool horaValida = false;
            //while (!horaValida)
            //{
            //    Console.Write("Indique a hora do dia (0-23): ");
            //    if (int.TryParse(Console.ReadLine(), out hora) && hora >= 0 && hora <= 23)
            //        horaValida = true;
            //    else
            //        Console.WriteLine("Hora inválida. Introduza um valor entre 0 e 23.\n");
            //}

            //// Definir tipo de playlist baseado no humor
            //if (humor == "feliz")
            //    tipoPlaylist = "animada";
            //else if (humor == "neutro")
            //    tipoPlaylist = "equilibrada";
            //else if (humor == "triste")
            //    tipoPlaylist = "calma";

            //// Definir intensidade baseada na hora do dia
            //if (hora >= 6 && hora < 12)
            //    intensidade = "suave";
            //else if (hora >= 12 && hora < 18)
            //    intensidade = "média";
            //else if (hora >= 18 && hora < 24)
            //    intensidade = "relaxante";
            //else
            //    intensidade = "relaxante"; // madrugada (0-5)

            //// Mostrar resultado
            //Console.WriteLine("\n--- Recomendação Musical ---");
            //Console.WriteLine($"Humor: {humor}");
            //Console.WriteLine($"Hora: {hora}h");
            //Console.WriteLine($"\nA sua playlist {tipoPlaylist} será {intensidade}!");


            // 12. Seleção de seguro automóvel
            int idade = 0;
            string tipoCarro = "";
            string historicoAcidentes = "";
            int nivelRisco = 0;

            // Ler e validar idade
            bool idadeValida = false;
            while (!idadeValida)
            {
                Console.Write("Indique a sua idade: ");
                if (int.TryParse(Console.ReadLine(), out idade) && idade >= 18)
                    idadeValida = true;
                else
                    Console.WriteLine("Idade inválida. Deve ter pelo menos 18 anos.\n");
            }

            // Ler e validar tipo de carro
            bool carroValido = false;
            while (!carroValido)
            {
                Console.Write("Indique o tipo de carro (desportivo, sedan ou SUV): ");
                tipoCarro = Console.ReadLine().Trim().ToLower();
                if (tipoCarro == "desportivo" || tipoCarro == "sedan" || tipoCarro == "suv")
                    carroValido = true;
                else
                    Console.WriteLine("Tipo de carro inválido. Tente novamente.\n");
            }

            // Ler e validar histórico de acidentes
            bool historicoValido = false;
            while (!historicoValido)
            {
                Console.Write("Tem histórico de acidentes? (sim ou não): ");
                historicoAcidentes = Console.ReadLine().Trim().ToLower();
                if (historicoAcidentes == "sim" || historicoAcidentes == "não" || historicoAcidentes == "nao")
                    historicoValido = true;
                else
                    Console.WriteLine("Resposta inválida. Responda 'sim' ou 'não'.\n");
            }

            // Normalizar resposta
            if (historicoAcidentes == "não")
                historicoAcidentes = "nao";

            // Definir risco base (1=baixo, 2=médio, 3=médio-alto, 4=alto)
            if (tipoCarro == "desportivo")
                nivelRisco = 4; // alto
            else if (tipoCarro == "sedan")
                nivelRisco = 2; // médio
            else if (tipoCarro == "suv")
                nivelRisco = 3; // médio-alto

            // Ajustar risco por idade
            if (idade < 21)
            {
                nivelRisco++;
                Console.WriteLine("\nAjuste aplicado: Idade inferior a 21 anos (+1 categoria de risco)");
            }

            // Ajustar risco por histórico de acidentes
            if (historicoAcidentes == "sim")
            {
                nivelRisco++;
                Console.WriteLine("Ajuste aplicado: Histórico de acidentes (+1 categoria de risco)");
            }

            // Determinar categoria final de risco
            string categoriaRisco = "";
            if (nivelRisco <= 1)
                categoriaRisco = "baixo";
            else if (nivelRisco == 2)
                categoriaRisco = "médio";
            else if (nivelRisco == 3)
                categoriaRisco = "médio-alto";
            else if (nivelRisco == 4)
                categoriaRisco = "alto (máximo)";

            // Mostrar resultado
            Console.WriteLine("\n--- Análise de Seguro Automóvel ---");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Tipo de carro: {tipoCarro}");
            Console.WriteLine($"Histórico de acidentes: {historicoAcidentes}");

            if (nivelRisco > 4)
            {
                Console.WriteLine("\nCIRCULAÇÃO PROIBIDA!");
                Console.WriteLine("O nível de risco excede o máximo permitido.");
                Console.WriteLine("Não é possível emitir seguro para este perfil.");
            }
            else
            {
                Console.WriteLine($"\nNível de risco: {categoriaRisco}");
                Console.WriteLine("Seguro aprovado!");
            }



        }
    }
}
