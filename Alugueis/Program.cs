using Alugueis;

Console.WriteLine("digite a quantidade de quartos a ser alugado");
int quartos = int.Parse(Console.ReadLine());
CadAlugeis[] alug = new CadAlugeis[quartos];
for (int i=0;i<quartos;i++) 
{

    Console.WriteLine("digite o nome");
    alug[i].Nome = Console.ReadLine();
    Console.WriteLine("digite o email");
    alug[i].Email = Console.ReadLine();
    Console.WriteLine("digite o numero do quarto");
    alug[i].NumeroQuarto = Console.ReadLine();
    Console.WriteLine("digite o valor do aluguel");
    alug[i].Aluguel = double.Parse(Console.ReadLine());
}
Console.WriteLine("Alugueis cadastrados:");
for (int i = 0; i < quartos; i++)
{
    Console.WriteLine($"Nome: {alug[i].Nome}, Email: {alug[i].Email}, Quarto: {alug[i].NumeroQuarto}, Aluguel: {alug[i].Aluguel}");
}