Console.Clear();
Console.WriteLine("Digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine("Digite seu sobrenome");
string sobrenome = Console.ReadLine();

Console.WriteLine($"ok {nome}! Agora vamos dar as boas vindas a voce!!");

Console.WriteLine($"Por favor escolha uma opção abaixo: ");
Console.WriteLine($" 1- Saudar com nome ");
Console.WriteLine($" 2- Saudar com sobrenome");
Console.WriteLine($" 3- Saudar com nome e sobrenome");
Console.WriteLine($" 0- Apenas saudacao genetica");
int opcao = int.Parse(Console.ReadLine());
Console.Clear();

switch (opcao)
{
    case 0:
        SaudacaoGenerica();
        break;

    case 1:
        SaudacaoNome(nome);
        break;

    case 2:
        SaudarComSobrenome(sobrenome);
        break;

    case 3:
        string nomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem vindo {nomeCompleto}");
        break;

    default:
        break;
}



void SaudacaoGenerica()
{
    Console.WriteLine($"Olá, seja bem-vindo ao nosso programa, tenha um ótimo dia :)");
}

void SaudacaoNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem-vindo, {nomeRecebido}");
}

void SaudarComSobrenome(string sobrenome)
{
    Console.WriteLine($"Seja bem-vindo, {sobrenome}");
}

string DevolveNomeCompleto (string nomeRecebido, string sobrenomeRecebido)
{
    return $"{nomeRecebido} {sobrenomeRecebido}";
}