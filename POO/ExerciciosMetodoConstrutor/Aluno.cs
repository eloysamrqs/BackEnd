namespace ExerciciosMetodoConstrutor
{
    public class Aluno
    {
        public string Nome;
        public double Nota;

        public Aluno()
        {
            Nome = "Aluno Desconhecido";
            Nota = 0;
        }

        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Aluno: {Nome} - Nota: {Nota:F1}"); 
            Console.WriteLine();
        }
    }
}
