string nome;
int numero1;
int numero2;

//pedir os nome pro usuario
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine(); //pede o numero do usuario

//pedir os dois numeros
Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine()); //converte o texto em numero

Console.WriteLine("Digite o segundo numero");
numero2 = int.Parse(Console.ReadLine()); //converte o texto em numero

//somar os dois numeros
int soma = numero1 + numero2;

//exibir nome e a soma
Console.WriteLine(nome); //exibe o nome do usuario
Console.WriteLine(soma); //exibe o nome do usuario

