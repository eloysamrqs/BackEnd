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

Carro fusca = new Carro();
fusca.DefinirMarca("Volkswagen");
fusca.DefinirModelo("Fusca");
fusca.Acelerar(50);
fusca.Acelerar(30);
fusca.Frear(20);
Console.WriteLine($"Marca: {fusca.ObterMarca()}");
Console.WriteLine($"Modelo: {fusca.ObterModelo()}");
Console.WriteLine($"Velocidade Atual: {fusca.ObterVelocidade()} km/h");


    

