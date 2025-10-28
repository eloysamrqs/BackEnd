string[] nome = new string[3];
int[] saldos = new int[3];
int opcao = -1;
int totalClientes = 0;

do
{
    Console.Clear();
    Console.WriteLine("========== SISTEMA BANCÁRIO SIMPLES ==========");
    Console.WriteLine("1. Cadastrar Cliente");
    Console.WriteLine("2. Depositar");
    Console.WriteLine("3. Sacar");
    Console.WriteLine("4. Transferir");
    Console.WriteLine("5. Listar Clientes");
    Console.WriteLine("0. Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Encerrando...");
            Console.WriteLine("Pressione <Enter> para sair.");
            Console.ReadLine();
            break;

        case 1:
            CadastrarClientes();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarClientes();
            break;

        default:
            Console.WriteLine("Opção Inválida! Pressione <Enter> para continuar...");
            Console.ReadLine();
            break;
    }

} while (opcao != 0);


// =================== FUNÇÕES ===================

void CadastrarClientes()
{
    Console.Clear();

    if (totalClientes >= nome.Length)
    {
        Console.WriteLine("Limite de clientes atingido!");
        Console.WriteLine("Pressione <Enter> para continuar...");
        Console.ReadLine();
        return;
    }

    Console.Write("Digite o nome do Cliente: ");
    nome[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    Console.WriteLine($"Cliente {nome[totalClientes]} cadastrado com ID: {totalClientes}");
    totalClientes++;

    Console.WriteLine("Cliente cadastrado com sucesso!");
    Console.WriteLine("Pressione <Enter> para continuar...");
    Console.ReadLine();
}

void ListarClientes()
{
    Console.Clear();
    Console.WriteLine("========== LISTAR CLIENTES ==========\n");

    if (totalClientes == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado.");
    }
    else
    {
        for (int i = 0; i < totalClientes; i++)
        {
            Console.WriteLine($"{i} - {nome[i]} / Saldo: R$ {saldos[i]:0.00}");
        }
    }

    Console.WriteLine("\nPressione <Enter> para continuar...");
    Console.ReadLine();
}

void Depositar()
{
    Console.Clear();
    Console.WriteLine("========== DEPOSITAR ==========\n");

    if (totalClientes == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado.");
        Console.WriteLine("Pressione <Enter> para continuar...");
        Console.ReadLine();
        return;
    }

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nome[i]} / Saldo: R$ {saldos[i]:0.00}");
    }

    Console.Write("\nDigite o número do cliente para depósito: ");
    int indice = int.Parse(Console.ReadLine());

    if (indice < 0 || indice >= totalClientes)
    {
        Console.WriteLine("Cliente inválido!");
    }
    else
    {
        Console.Write("Digite o valor para depositar: R$ ");
        int valor = int.Parse(Console.ReadLine());
        saldos[indice] += valor;
        Console.WriteLine($"Depósito realizado com sucesso! Novo saldo: R$ {saldos[indice]:0.00}");
    }

    Console.WriteLine("Pressione <Enter> para continuar...");
    Console.ReadLine();
}

void Sacar()
{
    Console.Clear();
    Console.WriteLine("========== SACAR ==========\n");

    if (totalClientes == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado.");
        Console.WriteLine("Pressione <Enter> para continuar...");
        Console.ReadLine();
        return;
    }

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nome[i]} | Saldo: R$ {saldos[i]:0.00}");
    }

    Console.Write("\nDigite o número do cliente para saque: ");
    int indice = int.Parse(Console.ReadLine());

    if (indice < 0 || indice >= totalClientes)
    {
        Console.WriteLine("Cliente inválido!");
    }
    else
    {
        Console.Write("Digite o valor para sacar: R$ ");
        int valor = int.Parse(Console.ReadLine());

        if (valor > saldos[indice])
        {
            Console.WriteLine("Saldo insuficiente!");
        }
        else
        {
            saldos[indice] -= valor;
            Console.WriteLine($"Saque realizado com sucesso! Novo saldo: R$ {saldos[indice]:0.00}");
        }
    }

    Console.WriteLine("Pressione <Enter> para continuar...");
    Console.ReadLine();
}

void Transferir()
{
    Console.Clear();
    Console.WriteLine("========== TRANSFERIR ==========\n");

    if (totalClientes < 2)
    {
        Console.WriteLine("É necessário ter pelo menos dois clientes para transferir.");
        Console.WriteLine("Pressione <Enter> para continuar...");
        Console.ReadLine();
        return;
    }

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nome[i]} / Saldo: R$ {saldos[i]:0.00}");
    }

    Console.Write("\nDigite o número do cliente que vai transferir: ");
    int origem = int.Parse(Console.ReadLine());

    Console.Write("Digite o número do cliente que vai receber: ");
    int destino = int.Parse(Console.ReadLine());

    if (origem < 0 || origem >= totalClientes || destino < 0 || destino >= totalClientes)
    {
        Console.WriteLine("Cliente inválido!");
    }
    else
    {
        Console.Write("Digite o valor da transferência: R$ ");
        int valor = int.Parse(Console.ReadLine());

        if (valor > saldos[origem])
        {
            Console.WriteLine("Saldo insuficiente para transferência!");
        }
        else
        {
            saldos[origem] -= valor;
            saldos[destino] += valor;
            Console.WriteLine("Transferência realizada com sucesso!");
        }
    }

    Console.WriteLine("Pressione <Enter> para continuar...");
    Console.ReadLine();
}