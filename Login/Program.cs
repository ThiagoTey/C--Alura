Dictionary<string, string> usuarios =  new Dictionary<string, string>
{
    {"teste", "senha" },
    {"usuario", "senha2" }
};

void login()
{
    Console.WriteLine("Insira seu usuario : ");
    string nomeUsuario = Console.ReadLine()!;
    Console.WriteLine("Insira sua senha: ");
    string senhaUsuario = Console.ReadLine()!;

    if(usuarios.ContainsKey(nomeUsuario))
    {
        if (usuarios[nomeUsuario] == senhaUsuario)
        {
            Console.WriteLine("Logado com sucesso!");
        } else
        {
            Console.WriteLine("Senha incorreta");
        }
    } else
    {
        Console.WriteLine("Usuário incorreto");
    }
}

login();