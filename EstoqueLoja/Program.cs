Dictionary<string, int> estoque = new Dictionary<string, int>
{
    { "Laranja" , 20 },
    { "Pera" , 10 },
    { "Pao" , 25 },
    { "Leite" , 3 },
    { "Maça" , 22 },
    { "Coca-Cola" , 2 },
};

void Menu ()
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao menu!");
    Console.Write("Digite o nome do produto para ver seu estoque : ");
    string produto = Console.ReadLine()!;
    
    ProcurarProduto(produto);
}

void ProcurarProduto(string produto)
{
    if (estoque.ContainsKey(produto))
    {
        Console.WriteLine($"Produto : {produto} tem {estoque[produto]} no estoque");
        Console.WriteLine("Digite qualquer tecla para voltar");
        Console.ReadKey();
    } else
    {
        Console.WriteLine("Produto não encontrado");
        Console.WriteLine("Digite qualquer tecla para voltar");
        Console.ReadKey();
    }
    Menu();
}

Menu();