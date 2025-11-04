namespace ExerciciosMetodoConstrutor
{
    public class MediaAluno
    {
        public string Nome;
        public double N1, N2, N3;

        //construtor com parametros
        public MediaAluno(double param1, double param2, double param3)
        {
            //Define os valores iniciais
            N1 = param1;
            N2 = param2;
            N3 = param3;
        }
        public MediaAluno()
        {
            N1 = N2 = N3 = 0;
        }

        public void Media()
        {
            double Media = (N1 + N2 + N3) / 3;

            Console.WriteLine($"A media do(a) {Nome} foi: {Media}");
        }
    }

}