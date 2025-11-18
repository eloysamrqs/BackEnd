using Exemplos;

// Cachorro toto = new Cachorro();
// Gato gatinho = new Gato();
// Aluno elo = new Aluno();

Console.Clear();
ContaCorrente c1 = new ContaCorrente();
c1.Depositar(3000);
c1.Sacar(2000);

ContaPoupanca p1 = new ContaPoupanca();
p1.Depositar(3000);
p1.Sacar(2000);
p1.CalcularSaldo();