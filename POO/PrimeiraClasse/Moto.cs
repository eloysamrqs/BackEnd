namespace PrimeiraClasse
{
    public class Moto
    {
        //propriedades
        public string marca = "";
        public string modelo = "";
        public string cor = "";
        public int qtdRodas;

        //metódos
        public void Acelerar()
        {
            Console.WriteLine($"Vrum tu tu tu tu tu");
        }
        public void Ligar()
        {
            Console.WriteLine($"Vrum, vrum...");
        }
        public void Desligar()
        {
            Console.WriteLine($"Moto desligando");
        }
    }
}