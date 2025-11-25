
using System.Runtime.Intrinsics.X86;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        //Construtores
        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            if ( saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
            
        }  

        public void Depositar (float Valor)
        {
            if ( Valor >= 0)
            {
                Saldo = Valor;
                return;
            }

            Console.WriteLine($"Valor para depositótrio inválido");
        }

        public float GetSaldo ()
        {
            return Saldo;
        }

        public void Sacar ( float Valor)
        {
            if ( Valor >= Saldo || Valor < 0)
            {
                Console.WriteLine($"Saldo insuficiente para saque de R${Valor}");
                return;
            }
            else
            {
                Saldo -= Valor;
            }

            
        }
        

    }
}