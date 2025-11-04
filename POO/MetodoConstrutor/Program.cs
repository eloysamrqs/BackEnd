using MetodoConstrutor;

Pessoa3SobreCargas PrimeiraPessoa = new Pessoa3SobreCargas();
Console.WriteLine($"Digite o seu nome");
PrimeiraPessoa.Nome = Console.ReadLine();
Console.WriteLine($"Digite a sua idade");
PrimeiraPessoa.Idade = int.Parse(Console.ReadLine());



Pessoa3SobreCargas SegundaPessoa = new Pessoa3SobreCargas("Mateus Latorre");
Console.WriteLine($"Digite o seu nome");
SegundaPessoa.Nome = Console.ReadLine();
Console.WriteLine($"Digite a sua idade");
SegundaPessoa.Idade = int.Parse(Console.ReadLine());



Pessoa3SobreCargas TerceiraPessoa = new Pessoa3SobreCargas();
Console.WriteLine($"Digite o seu nome");
TerceiraPessoa.Nome = Console.ReadLine();
Console.WriteLine($"Digite a sua idade");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());






