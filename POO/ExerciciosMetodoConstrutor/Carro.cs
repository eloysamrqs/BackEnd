using System.IO.Pipes;

namespace ExerciciosMetodoConstrutor
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string m, string mo, int a)
        {
            Marca = m;
            Modelo = mo;
            Ano = a;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Carro: {Marca} - {Modelo}, Ano: {Ano}");
            Console.WriteLine();
        }
    }
}