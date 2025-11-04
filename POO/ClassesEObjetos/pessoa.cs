namespace ClassesEObjetos
{
    public class pessoa
    {
        public string Nome = "";
        public int Idade;
        public void Falar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}");
        }
        public void Envelhecer(int _anos)
        {
            Idade++;
            
        }

    }
}