namespace ExerciciosMetodoConstrutor
{
    public class Retangulo
    {
        public double Altura = 0;

        public double Largura = 0;

        public double Area = 0;

        public Retangulo(double A, double L)
        {
            Altura = A;
            Largura = L;
        }
        
        public Retangulo()
        {
            Altura = 1;
            Largura = 1;
        }
        public void AreaRetangulo()
        {
            Area = Altura * Largura;
            Console.WriteLine($"A área do retângulo é {Area}");
        }
    }
}