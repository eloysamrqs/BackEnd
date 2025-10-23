//Faça um programa que solicite ao usuario um numero de repeticoes "x". Para cada repeticao
//solicite dois numeros e imrpima qual é o maior deles.

int q = 0, i = 0, n1 = 0, n2 = 0;

Console.WriteLine("Digite quantas vezes quer comparar");
q = int.Parse(Console.ReadLine());

while (i <= q)
{
    Console.WriteLine("Digite o primeiro número");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O número {n1} é maior que o número {n2}");
    }
    else if (n1 < n2)
    {
        Console.WriteLine($"O número {n2} é maior que o número {n1}");
    }
    else
    {
        Console.WriteLine($"O número {n1} é igual ao número {n2}");
    }
    i++;
}
