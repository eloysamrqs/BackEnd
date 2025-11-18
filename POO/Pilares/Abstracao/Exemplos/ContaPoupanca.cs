namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public override void Depositar(float valor)
        {
            Saldo += valor;
            Console.WriteLine($"Saldo {Saldo}");
        }

        public override void Sacar(float valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saldo {Saldo}");
        }
        public void CalcularSaldo()
        {
            Saldo += 0.05f * Saldo;
            Console.WriteLine($"Saldo {Saldo}");

        }
    }
}