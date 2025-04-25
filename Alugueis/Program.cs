using Alugueis;

Console.WriteLine("digite a quantidade de quartos a ser alugado");
int quartos = int.Parse(Console.ReadLine());
CadAlugeis alug = new CadAlugeis();
for (int i=0;i<quartos;i++) 
{

    Console.WriteLine("digite o nome");
    alug.Nome = Console.ReadLine();
    Console.WriteLine("digite o email");
    alug.Email = Console.ReadLine();
    Console.WriteLine("digite o numero do quarto");
    alug.NumeroQuarto = Console.ReadLine();
    Console.WriteLine("digite o valor do aluguel");
    alug.Aluguel = double.Parse(Console.ReadLine());
}
Console.WriteLine("Alugueis cadastrados:");
for (int i = 0; i < quartos; i++)
{
    Console.WriteLine($"Nome: {alug.Nome}, Email: {alug.Email}, Quarto: {alug.NumeroQuarto}, Aluguel: {alug.Aluguel}");
}