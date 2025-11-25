// See https://aka.ms/new-console-template for more information
using System.Net.WebSockets;
using ClassesEstaticas;

Console.WriteLine("Bem-Vindo ao programa!");
Console.WriteLine();

// Console.WriteLine($"Digite um número: ");
// float a = float.Parse(Console.ReadLine());
// Console.WriteLine($"Digite outro número: ");
// float b = float.Parse(Console.ReadLine());

// //Uso da classe estática de forma auxiliar
// Console.WriteLine($"Soma: {CalculosMatematicos.Somar(a, b)}");
// Console.WriteLine($"-----------------------------------");
// Console.WriteLine($"Subtração: {CalculosMatematicos.Subtrair(a, b)}");
// Console.WriteLine($"-----------------------------------");
// Console.WriteLine($"Multiplicação: {CalculosMatematicos.Multiplicar(a, b)}");
// Console.WriteLine($"-----------------------------------");
// Console.WriteLine($"Divisão: {CalculosMatematicos.Dividir(a, b)}");
// Console.WriteLine($"-----------------------------------");



// Solicitar ao usuário que insira dois números reais e informar qual deles é o maior e qual é o menor. 
// //Para isso, utilize a classe estática Math da biblioteca padrão do C#.
Console.WriteLine("Digite o primeiro número: ");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
float n2 = float.Parse(Console.ReadLine());
if (n1 == n2)
{   
    Console.WriteLine("Os números são iguais.");
} 
else
{
    Console.WriteLine("O maior é: {Math.Max(n1, n2)}");
    Console.WriteLine("O menor é: {Math.Min(n1, n2)}");
}