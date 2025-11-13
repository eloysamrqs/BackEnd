namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {    
        public string Nome = "";

        public double Preco = 0;

        public int Estoque = 0;

        public Produto(int E, double P, string N)
        {
            Nome = N;
            Preco = P;
            Estoque = E;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} | Preço: R${Preco} | Estoque: {Estoque}");
        }
    }
}