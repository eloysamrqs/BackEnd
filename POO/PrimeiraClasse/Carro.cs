
using System.Net.NetworkInformation;

namespace PrimeiraClasse
{
    public class Carro
    {
        //propriedades
        public int qtdRodas;
        public int qtdPortas;
        public string marca = "";
        public string modelo = "";
        public string cor = "";

        //metódos
        public void Acelerar()
        {
            Console.WriteLine($"Carro acelerando");
        }
        public void Frear()
        {
            Console.WriteLine($"Carro freando");
        }
        public void Ligar()
        {
            Console.WriteLine($"Carro ligando");
        }
        public void Desligar()
        {
            Console.WriteLine($"Carro desligando");
        }
    }
}