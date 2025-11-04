namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public Produto(string n, double p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }
        
        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome} - Preço: R${Preco:F2} - Estoque: {Estoque} ");
            Console.WriteLine();
        }
    }
}