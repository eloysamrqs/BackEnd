namespace ExerciciosMetodoConstrutor
{
    public class Carro
    {

        public string Marca = "";

        public string Modelo = "";

        public int Ano = 0;

        public Carro(int a, string mod, string mar)
        {
            Marca = mar;
            Modelo = mod;
            Ano = a;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca} | Modelo: {Modelo} | Ano: {Ano}");
            
        }
    }
}