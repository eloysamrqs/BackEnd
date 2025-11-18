using System.Runtime.ConstrainedExecution;
using Exercicio2;

// Cria uma lista de objetos Fatura
List<IImprimivel> documentos = new List<IImprimivel>();

// Fatura fatEdu = new Fatura("Eduardo", "Dark Lab", 150, 1);
// fatEdu.Imprimir();

int opcao;
do
{
    Console.Clear();
//cRIAR UM MENU DA SEGUINTE FORMA
    Console.WriteLine($"Menu de opções");
    Console.WriteLine($@"
    1) Cadastrar Fatura
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatórios
    6) Listar Contratos
    Escolha uma opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar Fatura");
            break;
        case 2:
            Console.WriteLine($"cadastrar Relatório");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato");
            break;
        case 4:
            Console.WriteLine($"Cadastrar Contrato");
            break;
        case 5:
            Console.WriteLine($"Cadastrar Contrato");
            break;
         case 6:
            Console.WriteLine($"Cadastrar Contrato");
            break;
            
        

    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();

    }while (opcao != 0);
