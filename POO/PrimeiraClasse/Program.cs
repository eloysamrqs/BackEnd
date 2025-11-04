using PrimeiraClasse;
// // string nome = "Eduardo Costa";
// // //crie um objeto do tipo Hello
// // Hello cumprimento = new Hello();

// // cumprimento.TextoHello = "Olá usuário";

// // cumprimento.SaudarUsuario();
// // cumprimento.SaudarComNome("Mateus Latorre");
// using PrimeiraClasse;

// Carro c1 = new Carro();
// c1.marca = "lamborghini";
// c1.modelo = "Urus";
// c1.cor = "Azul";
// c1.qtdPortas = 2;
// c1.qtdRodas = 4;
// c1.Ligar();
// c1.Acelerar();
// c1.Frear();
// c1.Desligar();

// Carro c2 = new Carro();
// c2.marca = "Chevrolet";
// c2.modelo = "Camaro";
// c2.cor = "Amarelo";
// c2.qtdPortas = 2;
// c2.qtdRodas = 4;

// Console.WriteLine($"Ligando o {c2.modelo}");
// Console.WriteLine($"Acelerando o {c2.modelo}");
// Console.WriteLine($"Freando o {c2.modelo}");
// Console.WriteLine($"Desligando o {c2.modelo}");

// Console.WriteLine($"");
// Console.WriteLine($"Características");
// Console.WriteLine($"");


// Console.WriteLine($"-------- {c1.marca} --------");


// Console.WriteLine($"Carro: {c1.marca}");
// Console.WriteLine($"Modelo: {c1.modelo}");
// Console.WriteLine($"Cor: {c1.cor}");
// Console.WriteLine($"Quantidade de Portas: {c1.qtdPortas}");
// Console.WriteLine($"");
// Console.WriteLine($"---");
// Console.WriteLine($"");



// Console.WriteLine($"-------- {c2.marca} --------");


// Console.WriteLine($"Carro: {c2.marca}");
// Console.WriteLine($"Modelo: {c2.modelo}");
// Console.WriteLine($"Cor: {c2.cor}");
// Console.WriteLine($"Quantidade de Portas: {c2.qtdPortas}");
// Console.WriteLine($"");

// using PrimeiraClasse;

// Moto m1 = new Moto();
// m1.marca = "Honda";
// m1.modelo = "Pop100";
// m1.cor = "Verde";
// m1.qtdRodas = 2;
// m1.Ligar();
// m1.Acelerar();

// Moto m2 = new Moto();
// m2.marca = "Yamaha";
// m2.modelo = "FZ15ABS";
// m2.cor = "Amarelo";
// m2.qtdRodas = 2;

// Console.WriteLine($"");
// Console.WriteLine($"Características");
// Console.WriteLine($"");


// Console.WriteLine($"-------- {m1.marca} --------");


// Console.WriteLine($"Moto: {m1.marca}");
// Console.WriteLine($"Modelo: {m1.modelo}");
// Console.WriteLine($"Cor: {m1.cor}");
// Console.WriteLine($"Quantidade de Rodas: {m1.qtdRodas}");
// Console.WriteLine($"");
// Console.WriteLine($"---");
// Console.WriteLine($"");

// Console.WriteLine($"Ligando o {m1.modelo}");
// Console.WriteLine($"Acelerando o {m1.modelo}");
// Console.WriteLine($"Freando o {m1.modelo}");


// Console.WriteLine($"-------- {m2.marca} --------");


// Console.WriteLine($"Moto: {m2.marca}");
// Console.WriteLine($"Modelo: {m2.modelo}");
// Console.WriteLine($"Cor: {m2.cor}");
// Console.WriteLine($"Quantidade de Rodas: {m2.qtdRodas}");
// Console.WriteLine($"");
// Console.WriteLine($"---");
// Console.WriteLine($"");

// Console.WriteLine($"Ligando o {m2.modelo}");
// Console.WriteLine($"Acelerando o {m2.modelo}");
// Console.WriteLine($"Freando o {m2.modelo}");

//criar uma classe para representar uma garrafa, propriedades, metodos

garrafa g1 = new garrafa();
Console.WriteLine($"Olá usuário, vamos personalizar sua garrafa");
Console.WriteLine($"Qual será a marca da sua garrafa?");
g1.marca = Console.ReadLine();

Console.WriteLine($"Qual será o modelo da sua garrafa?");
g1.modelo = Console.ReadLine();

Console.WriteLine($"Qual será a cor da sua garrafa?");
g1.cor = Console.ReadLine();

Console.WriteLine($"Qual será a capacidade da sua garrafa (em ml)?");
g1.capacidade = int.Parse(Console.ReadLine());

Console.WriteLine($"");
Console.WriteLine($"----- {g1.marca} -----");

Console.WriteLine($"Garrafa: {g1.marca}");
Console.WriteLine($"Modelo: {g1.modelo}");
Console.WriteLine($"Cor: {g1.cor}");
Console.WriteLine($"Capacidade: {g1.capacidade}");
Console.WriteLine($"--------------------");
Console.WriteLine($"");


