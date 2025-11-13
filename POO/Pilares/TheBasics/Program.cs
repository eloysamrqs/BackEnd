using System.Net.WebSockets;
using TheBasics;
Console.Clear();

// // array/ lista de pessoas
// List<Pessoa> peoples = new List<Pessoa>();
// //*************EDUARDO****************
// // Endereço
// Endereco enderecoEdu = new Endereco();
// enderecoEdu.Logradouro = "Rua Niterói";
// // Pessoa com endereço
// Pessoa edu = new Pessoa(enderecoEdu);
// edu.Nome = "Eduardo Costa";
// edu.Idade = 43;

// //*************ALEXIA****************
// // Endereço
// Endereco endAlexia = new Endereco();
// endAlexia.Logradouro = "Rua lá";
// // Pessoa com endereço
// Pessoa alexia = new Pessoa(endAlexia);
// alexia.Nome = "Alexia Vitoria";
// alexia.Idade = 24;

// // Guardando os dados na lista

// peoples.Add(edu);// 0
// peoples.Add(alexia);// 1


// foreach (var p in peoples)
// {
//     Console.WriteLine($"Nome: {p.Nome}");
// }

//------------------------------------------------------------------------
// Endereco endEnzo= new Endereco();
// endEnzo.Logradouro = "Spinola Teixeira";
// endEnzo.Numero = 3960;

// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Pedro Enzo";
// pedroEnzo.Curso = "Desenvolvimento de Sistemas";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 9.75f;

// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua lá de casa";
// endProfAlex.Numero = 897;

// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Aléxia Vitória";

// Console.WriteLine($"Aluno {pedroEnzo.Nome} estuda na turma {pedroEnzo.Curso} da prof {profAlexia.Nome}");

//------------------------------------------------------------------------
Carro fusca = new Carro();
fusca.Marca = "Wolksvagem";
fusca.Modelo = "Fusca 79";
fusca.Ano = 1969;

Moto dominar400 = new Moto();
dominar400.Marca = "Bejaj";
dominar400.Modelo = "Dominar 400";

fusca.Acelerar();

dominar400.Empinar();
