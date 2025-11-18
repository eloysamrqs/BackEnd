namespace Exercicio1
{
    public class Circulo : IForma 
    {
        public float Raio;
        private float PI = 3.14f;
        public void CalcularArea()
        {
            Console.WriteLine($"A área do Círculo é: {PI * Raio * Raio}");
        }
    }
}