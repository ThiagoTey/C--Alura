// Screen Sound
string msgBoasVindas = "Boas Vindas ao Screen Sound";
//List<string> listaDeBandas = new List<string> { "Slipknot", "The Beatles", "Artic Monkeys"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Slipknot", new List<int> { 10, 9, 10, 8 });
bandasRegistradas.Add("Link Parkin", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(msgBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avalisar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida =  Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: MostrarAvaliacaoBanda();
            break;
        case -1: Console.WriteLine("Adeus");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitudoDaOpcao(titulo: "Registrar Bandas");

    Console.Write("Digite o nome da banda que deseja registrar : ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTitudoDaOpcao(titulo: "Registro de Bandas");

    //for(int i = 0; i < listaDeBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda : {listaDeBandas[i]}");
    //}

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda : {banda}");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    // digitar qual banda avaliar
    // se existir >> atribuir nota
    // se não > voltar / repetir
    Console.Clear();
    ExibirTitudoDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar :");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual nota a banda {nomeBanda} merece? : ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeBanda}");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MostrarAvaliacaoBanda()
{
    Console.Clear();
    ExibirTitudoDaOpcao("Mostrar Avaliação da banda");

    Console.WriteLine("");
}

void ExibirTitudoDaOpcao(string titulo)
{
    int qtdeLetra = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdeLetra, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();


//string sayHello = "Hello World!";
//Console.WriteLine(sayHello);
//sayHello = sayHello.Replace("Hello", "Greetings");
//Console.WriteLine(sayHello);