using System.Net.WebSockets;
using Encapsulamento;

// float dinheiro = 200;
// ContaBancaria contaElo = new ContaBancaria();
// ContaBancaria contaMaria = new ContaBancaria(dinheiro);
// contaElo.Depositar(dinheiro);

// Console.WriteLine($"Saldo da Elo: R${contaElo.GetSaldo()}");
// Console.WriteLine($"Saldo da Maria: R${contaMaria.GetSaldo()}");

// contaElo.Sacar(100);
// Console.WriteLine($"Saldo da Elo após saque: R${contaElo.GetSaldo()}"); 
         
Carro carro1 = new Carro();
carro1.DefinirMarca("Honda");    
carro1.DefinirModelo("Civic");
carro1.Acelerar(100);
Console.WriteLine($"Marca: {carro1.ObterMarca()}");
Console.WriteLine($"Modelo: {carro1.ObterModelo()}");

Console.WriteLine($"Velocidade Atual: {carro1.ObterVelocidade()} km/h");
carro1.Frear(20);
Console.WriteLine($"Velocidade Atual após frear: {carro1.ObterVelocidade()} km/h"); 
