//Faça um programa que receba 3 numeros interiros imprima na tela
//a somatoria total dos numeros.

int n, resultado = 0;

for(int i = 1; i <= 3; i++)
{
    Console.WriteLine("Digite o numero: ");
    n = int.Parse(Console.ReadLine());
    resultado += n;
}

Console.WriteLine($"A somatoria total é: {resultado}");