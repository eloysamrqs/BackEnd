//Exercicio 1 
//Crie uma interface chamada IForma com o método CalcularArea
//Crie duas classes que implentem essa Interface: Retangulo e Circulo
//No programa, peça os valores necessários 

//No retangulo utilizar o cáluco = Lagura * Altura;
//No Circulo utilizae o cálculo = PI * Raio * Raio;

using Exercicio1;

//Retângulo
Console.WriteLine($"===== Bem vindo ao programa Cálculos de Geometria =====");
Console.WriteLine();

Console.WriteLine($"Vamos calcular o Retângulo");

//Altura e Largura
Console.WriteLine($"Digite a largura do Retângulo: ");
float l = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a altura do Retângulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo= new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Agora vamos calcular a área do círculo");
Console.WriteLine($"Informe o raio do círculo");
float r = float.Parse(Console.ReadLine());

Circulo circulo= new Circulo();
circulo.Raio = r;
circulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Fim do programa");
Console.WriteLine();