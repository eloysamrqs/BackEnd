//Uma empresa decidar dar um aumento aos funcionarios de acordo com o seu cargo, dispostos na tabela abaixo, CARGO: Producao,Administrativo, Diretoria
//% Aumento: 6.5, 7,5,12
//De acordo com a tabela acim faça um programa que receba o cargo e o salario de um funcionario e calcule e imprima o salrio reajustado

string cargo;
double salario;
double salarioNovo = 0;

Console.WriteLine("Digite o cargo do funcionário: ");
cargo = Console.ReadLine();

Console.WriteLine("Digite o salário atual: ");
salario = double.Parse(Console.ReadLine());

// calcular o aumento
if (cargo == "Producao")
{
    salarioNovo = salario + (salario * 0.065);
}
else if (cargo == "Administrativo")
{
    salarioNovo = salario + (salario * 0.075);
}
else if (cargo == "Diretoria")
{
    salarioNovo = salario + (salario * 0.12);
}
else
{
    Console.WriteLine("Cargo inválido!");
    return; // encerra o programa aqui
}

Console.WriteLine("O novo salário reajustado é: " + salarioNovo);

