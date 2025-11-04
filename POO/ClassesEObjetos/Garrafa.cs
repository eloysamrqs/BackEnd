namespace ClassesEObjetos
{
    public class Garrafa
    {
        //propriedades
        public string marca = "";

        public string modelo = "";

        public int capacidade = 0;

        public string cor = "";


        //metodos
        public void Abrir()
        {
            Console.WriteLine($"Garrafa abrindo");
        }
        public void Encher()
        {
            Console.WriteLine($"Garrafa enchendo");
        }

        public void Esvaziar()
        {
            Console.WriteLine($"Garrafa Esvaziando");
        }

        public void Fechar()
        {
            Console.WriteLine($"Garrafa fechando");
        }
    }
}