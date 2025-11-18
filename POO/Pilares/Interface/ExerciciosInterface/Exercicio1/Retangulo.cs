namespace Exercicio1
{
    public class Retangulo : IForma
    {
        public float Altura;
        public float Largura;
        
        public void CalcularArea()
        {
            Console.WriteLine($"A área do Retângulo é: {Largura * Altura}");
        }
    }
}