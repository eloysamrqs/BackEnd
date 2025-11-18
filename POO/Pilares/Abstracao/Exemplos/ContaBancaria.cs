namespace Exemplos
{
    public abstract class ContaBancaria
    {
        public float Saldo = 0;
        public abstract void Depositar(float valor);
        public abstract void Sacar(float valor);
            
        
    }
}