
namespace TheBasics
{
    public class Veículo
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public virtual void Acelerar()
        {
            Console.WriteLine($"Acelerando o veículo");
        }
        public void Desligar()
        {
            Console.WriteLine($"Desligando o veículo");
        }
    }
}