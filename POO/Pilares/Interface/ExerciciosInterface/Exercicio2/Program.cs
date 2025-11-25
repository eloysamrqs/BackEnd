using Exercio2;

Console.Clear();
List<Relatorio> listaRelatorio = new List<Relatorio>();
List<Contrato> listaContrato = new List<Contrato>();
List<Fatura>  listaFatura = new List<Fatura>();

int opcao;
do
{
    Console.WriteLine($"Menu de Opções");
    Console.WriteLine($@"
    1) Cadastrar Fatura
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatórios
        6) Listar Contratos
    0) Sair
    Escolha a opção:");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite <Enter> para continuar ...");
    Console.ReadLine();

    switch (opcao)
    {
        case 1:
            CadastrarFatura();
            break;
        case 2:
            CadastrarRelatorio();
            break;
        case 3:
            CadastrarContrato();
            break;
        case 4:
            ListarFatura();
            break;
        case 5:
            ListarRelatorio();
            break;
        case 6:
            ListarContrato();
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"ERRO, opção não existente.");
            break;


    }
} while (opcao != 0);

void CadastrarFatura()
{
    Console.WriteLine("Digite o nome do devedor: ");
    string dev = Console.ReadLine();
    Console.WriteLine("Digite o nome do credor: ");
    string cred = Console.ReadLine();
    Console.WriteLine($"Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());
    Console.WriteLine($"Quantos dias a fatura está em atraso? ");
    int diasAtraso = int.Parse(Console.ReadLine());
    
    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    listaFatura.Add(f);
}
void CadastrarRelatorio()
{
    Console.WriteLine("Digite o nome do responsável pelo relatório: ");
    string responsavel = Console.ReadLine();
    Console.WriteLine("Digite o texto do relatório: ");
    string txtRelatorio = Console.ReadLine();
    
    Relatorio r = new Relatorio(responsavel,txtRelatorio);
    listaRelatorio.Add(r);
}
void CadastrarContrato()
{
    Console.WriteLine("Digite o nome do contratante: ");
    string contratante = Console.ReadLine();
    Console.WriteLine("Digite o nome do contratado: ");
    string contratado = Console.ReadLine();
    Console.WriteLine("Digite as cláusulas: ");
    string txtClausulas = Console.ReadLine();
    
    Contrato c = new Contrato(contratante, contratado, txtClausulas);
    listaContrato.Add(c);
}

void ListarRelatorio()
{
    foreach (var items in listaRelatorio)
    {
        items.Imprimir();
    }
}


void ListarContrato()
{
    foreach (var items in documentos)
    {
        items.Imprimir();
    }
}


void ListarFatura()
{
    foreach (var items in listaFatura)
    {
        items.Imprimir();
    }
}
