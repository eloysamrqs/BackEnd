// Faça um programa que receba 4 notas de um aluno, calcule e imprima a media
//aritmetica das notas e a mensagem de APORVADO prar media superior ou igual a 
//7,00 RECUPERACAO para notas entres 5.00 e 7.00 ou a mensagem de REPROVADO
//para media inferior a 5,0.

double nota1, nota2, nota3, nota4, media;

// pedir as notas
Console.WriteLine("Digite a primeira nota:");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota:");
nota4 = double.Parse(Console.ReadLine());

// calcular média
media = (nota1 + nota2 + nota3 + nota4) / 4;

// mostrar média
Console.WriteLine("A média do aluno é: " + media);

// 
if (media >= 7.0)
{
    Console.WriteLine("APROVADO!");
}
else if (media >= 5.0)
{
    Console.WriteLine("RECUPERAÇÃO!");
}
else
{
    Console.WriteLine("REPROVADO!");
}
