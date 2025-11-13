namespace ExerciciosMetodoConstrutor
{
    public class Aluno
    {
        public string Nome = "";
        public double Nota = 0;

        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public Aluno()
        {
            Nome = "Desconhecido";
            Nota = 0;
        }

    }
}