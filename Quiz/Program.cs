var quiz = new Dictionary<string, Dictionary<string, Dictionary<string, (string, bool)>>> {
    { "Quiz 1", new Dictionary<string, Dictionary<string, (string, bool)>>
        {
            { "Quanto é 2 + 2?", new Dictionary<string, (string, bool)>
                {
                    { "1", ("3", false) },
                    { "2", ("4", true) },
                    { "3", ("1", false) },
                    { "4", ("4.5", false) },
                }
            }
       }
    },
    { "Quiz 2", new Dictionary<string, Dictionary<string, (string, bool)>>
        {
            { "Quanto é 2 + 5?", new Dictionary<string, (string, bool)>
                {
                    { "1", ("7", true) },
                    { "2", ("2", false) },
                    { "3", ("1", false) },
                    { "4", ("outro", false) },
                }
            }
       }
    },
};

void Inicio()
{
    Console.WriteLine("Quiz Super dificil!!!\n");
    Console.WriteLine("pressione qualquer tecla para iniciar");
    Console.ReadKey();
    Quiz();

}

void Quiz()
{
    foreach(var quizItem in quiz)
    {
        do
        {
            string respostaCerta = "1";
            Console.Clear();
            Console.WriteLine(quizItem.Key  + "\n");
            foreach(var descricao in quizItem.Value) 
            {
                Console.WriteLine(descricao.Key); 
                foreach(var opcao in descricao.Value)
                {
                    Console.WriteLine($"{opcao.Key} - {opcao.Value.Item1}");
                    if(opcao.Value.Item2 == true)
                    {
                        respostaCerta = opcao.Key;
                    }
                }
            }

            Console.Write("Qual a resposta certa? : ");
            string resposta = Console.ReadLine()!;

            if( resposta == respostaCerta)
            {
                Console.WriteLine("Correto!!");
                Thread.Sleep(2000);
                break;
            } else
            {
                Console.WriteLine("Ta errado isso ae");
                Thread.Sleep(2000);
            }

            
        } while (true);
    }
}

Inicio();