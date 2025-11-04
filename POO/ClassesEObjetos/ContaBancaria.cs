namespace ClassesEObjetos
{
    public class ContaBancaria
    {
        public double Saldo = 0;

        public double Saque = 0;

        public string Titular = "";

        public void Sacar()
        {
            Console.WriteLine($"Quanto deseja sacar?");
            Saque = int.Parse(Console.ReadLine());
            if (Saque > Saldo)
            {
                Console.WriteLine("ERRO, não a saldo o suficiente para sacar");
                Console.WriteLine($"Seu saldo atual é de R${Saldo}");
            }
            else
            {
                Saldo -= Saque;
                Console.WriteLine($"Seu saldo atual é de R${Saldo}");
            }


        }
        public void Depositar()
        {
            Console.WriteLine($"Quanto deseja depositar?");
            Saldo += int.Parse(Console.ReadLine());
            Console.WriteLine($"Seu saldo atual é de R${Saldo}");
        }


    }
}