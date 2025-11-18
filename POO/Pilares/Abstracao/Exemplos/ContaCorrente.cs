namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public override void Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Saldo {Saldo}");
            }
            else
            {
                Console.WriteLine("ERRO: O valor depositado não pode ser igual á zero");
            }
        }

        public override void Sacar(float valor)
        {
            if (Saldo < 6.40f && valor > 0 && valor <= Saldo + 6.40f)
            {
                Saldo -= valor + 6.40f;
                Console.WriteLine($"Saldo {Saldo}");
            }
            else
            {
                Console.WriteLine("ERRO: O saldo e/ou o valor desejado não é suficiente");
            }
        }
    }
}