namespace ExerciciosMetodoConstrutor
{
    public class ContaBancaria
    {
        public string Titular = "";
        public double Saldo = 0;

        public ContaBancaria(string T, double S)
        {
            Titular = T;
            Saldo = S;
        }

        public ContaBancaria(string T)
        {
            Titular = T;
        }
    }
}