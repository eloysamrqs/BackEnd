namespace ExerciciosMetodoConstrutor
{
    public class Livro
    {
        public string Titulo = "";

        public double Preco = 0;

        public string Autor = "";

        public Livro(string T, double P, string A)
        {
            Titulo = T;
            Preco = P;
            Autor = A;
        }

        public Livro(string T, string A)
        {
            Titulo = T;
            Autor = A;
        }
    }
}