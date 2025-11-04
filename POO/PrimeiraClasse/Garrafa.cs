namespace PrimeiraClasse
{
    public class garrafa
    {
        //propriedades
        public string marca = "";
        public string modelo = "";
        public string cor = "";
        public int capacidade = 0;

        //metódos
        public void Encher()
        {
            Console.WriteLine($"Enchendo garrafa");
        }
        public void Esvaziando()
        {
            Console.WriteLine($"Esvaziando garrafa");
        }
        public void Fechar()
        {
            Console.WriteLine($"Fechando garrafa");
        }
        public void Abrir()
        {
            Console.WriteLine($"Abrindo garrafa");
        }	
    }
}