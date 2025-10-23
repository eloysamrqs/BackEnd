/*
Faça um programa que pergnte para o usuario a quantidade de numeros que ele quer
digitar. Apos isso crie um laço que exiba o numero que o usuario digitar
apenas se dor PAR. Utilize a estrutura WHILE
*/

//perguntar quantos numeros o usuario quer digitar
//criar um laço while baseado na quantidade de numeros que o usuario quer digitar
//dentro do laço, verificar se é par ou impar e imprimir $"Numero digitado é par {nDigitado}"

int q = 0, i = 1, n = 0;

Console.WriteLine("Quantos números você deseja digitar?");
q = int.Parse(Console.ReadLine());

while (i <= q)
{
    Console.WriteLine("Digite um número");
    n = int.Parse(Console.ReadLine());

    if (n % 2 == 0)
    {
        Console.WriteLine($"O número {n} é par");
    }
    i++;
}