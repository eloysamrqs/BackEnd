namespace ExerciciosMetodoConstrutor
{
    public class AlunoM
    {
        public string Nome = "";
        public double N1, N2, N3, M;

        public AlunoM(double n1, double n2, double n3)
        {
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }

        public AlunoM()
        {
            N1 = 0;
            N2 = 0;
            N3 = 0;
        }
        
        public void Media()
        {
            M = (N1 + N2 + N3) / 3;
            Console.WriteLine($"Média de {Nome}: {M}");   
        }
    }
}