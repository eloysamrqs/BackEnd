string nome;
int numero1;
int numero2;

//pedir os dois numeros
Console.WriteLine("Digite o primeiro numero");//pega o texto que o usuario digitar e transforma em texto
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");//pega o texto que o usuario digitar e transforma em texto
numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine($"O primeiro número é maior: {numero1}"); //interpola o valor da variavel numero1
}
else if (numero2 > numero1)
{
    Console.WriteLine($"O segundo número é maior: {numero2}");//interpola o valor da variavel numero2
}
else
{
    Console.WriteLine("Os dois números são iguais");
}
