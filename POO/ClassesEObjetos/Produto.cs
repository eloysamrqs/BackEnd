namespace ClassesEObjetos
{
    public class Produto
    {
        public string Nome = "";

        public double Preco = 0;

        public void AplicarDesconto(double percentual)
        {
            Console.WriteLine($"Adicione o percentual de desconto no formato 0,XX");
            Console.WriteLine($"(Ex: 10% = 0,10)");
            Console.WriteLine($"");
            Console.WriteLine($"");
            percentual = double.Parse(Console.ReadLine());
            Preco -= (percentual * Preco);
            Console.WriteLine($"O preço atual é de R${Preco}.");
            
        }
    }
}