
using System.Reflection.Metadata;

var aluno = new Dictionary<string, List<int>>
{
    { "C#", new List<int> {10,6,6,9}},
    { "Java", new List<int> {9,6,3,9}},
    { "Postgres", new List<int> {7,3,2,3}}
};

foreach(var item in aluno)
{
    double soma = 0;
    foreach(int value in item.Value)
    {
        soma = soma + value;
    }
    double media = soma/item.Value.Count;

    Console.WriteLine($"Disciplina: {item.Key} - média: {media}");
}