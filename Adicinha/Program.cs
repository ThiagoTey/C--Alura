
int continuar = 1;

Console.WriteLine("Jogo de adivinhação de número!");

while (continuar == 1)
{
    Random random = new Random();
    int randomNumber = random.Next(1, 100);
    Console.WriteLine("Jogo de adivinhação de número!");
    Console.Write("Digite um número de 1 a 100: ");

    int numeroSelecionado = 0;

    while (numeroSelecionado != randomNumber)
    {
         numeroSelecionado = int.Parse(Console.ReadLine()!);

        if (randomNumber > numeroSelecionado)
        {
            Console.WriteLine($"Número é maior que {numeroSelecionado}");
            Console.Write("Digite novamente : ");
        }
        else if (randomNumber < numeroSelecionado)
        {
            Console.WriteLine($"Número é menor que {numeroSelecionado}");
            Console.Write("Digite novamente : ");
        }

    }

    Console.WriteLine($"Parabéns! o número era {randomNumber}");


    Console.WriteLine("Deseja Continuar?");
    Console.WriteLine("Digite Y para sim - Outro para não");
    string escolha = Console.ReadLine()!;

    if (escolha.ToUpper() == "Y")
    {
        Console.WriteLine("Continuar");
    } else
    {
        Console.WriteLine("Finalizar");
        continuar = 2;
    }
}