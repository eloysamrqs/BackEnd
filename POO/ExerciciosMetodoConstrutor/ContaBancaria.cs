namespace ExerciciosMetodoConstrutor
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public ContaBancaria(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Titular: {Titular} - Saldo: R$ {Saldo:F2}");
            Console.WriteLine();
        }
    }
}