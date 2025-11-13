namespace Herança
{
    public class Conta
    {
        public int Numero = 0;
        public float Saldo = 0;

        public void Depositar()
        {
            Console.WriteLine($"Quanto você deseja depositar?");
            Saldo += float.Parse(Console.ReadLine());
            Console.WriteLine($"Seu saldo atual é de R${Saldo}");
        }

        public void Sacar()
        {
            if (Saldo > 0)
            {
                Console.WriteLine($"Quanto você deseja sacar?");
                Saldo -= float.Parse(Console.ReadLine());
                Console.WriteLine($"Seu saldo atual é de R${Saldo}");
            }
            else
            {
                Console.WriteLine("ERRO, você não tem saldo o suficiente!");
            }
        }
    }
}