//criacao de variaveis
string[] nomes = new string[4];
int [] idades = new int[4];
int opcao = -1, totalAlunos = 0;

do 
{
    Console.Clear();
    Console.WriteLine($"1) Cadastrar Alunos");
    Console.WriteLine($"2) Listar Alunos");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Digite uma opção");
    opcao = int.Parse(Console.ReadLine());

    //chamar a funcao correta
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Esperando...");
            Console.WriteLine($"Pressionr <Enter> para encerrar...");
            Console.ReadLine();//para o sistema e espra o usuario digitar Enter!!
            break;

        case 1:
            CadastrarAlunos();
            break;

        case 2:
            ListarAlunos();
        break;

        default:
            Console.WriteLine($"Opção inválida, pressione <Enter> para continuar...");
            Console.ReadLine();//para o sistema e espra o usuario digitar Enter!!
            break ;
    }//fim da switch
} while (opcao != 0);



//==============Funcao=================


void CadastrarAlunos()
{
    //verificar se tem espaço no array para cadastrar (totalAlunos)
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não limite de ocupação atingido");
        Console.WriteLine($"Pressione <Enter> para continuar"); 
        Console.ReadLine();
        return;
    }

    //pedir os dados para o usuario (nome, idade) 
    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    //guardar/cadastrar no array
    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine("Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} alunos(as) cadastrados(as) no sistema!");
    Console.WriteLine($"Pressione <Enter> para continuar"); 
    Console.ReadLine(); //para o sistema e esperar o usuario dar um <Enter>   
}


//funcao para exbibir alunos
void ListarAlunos()
{
    Console.WriteLine();//pula uma linha
    Console.WriteLine($"Resultado: ");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"  Nome: {nomes[i]} ");
        Console.WriteLine($"  Idade: {idades[i]} anos");
        Console.WriteLine();//pula uma linha
    }

    Console.WriteLine($"Pressione <Enter> para continuar"); 
    Console.ReadLine();
}
