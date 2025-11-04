namespace MetodoConstrutor
{
    public class Pessoa3SobreCargas
    {
        public string Nome;
        public int Idade;

        public Pessoa3SobreCargas()
        {
            Nome = "Desconhecido"; //valor fixo
            Idade = 0; //valor fixo
        }

        public Pessoa3SobreCargas(string N)
        {
            Nome = N; //valor dinamino
            Idade = 0; //valor fixo
        }
        
        public Pessoa3SobreCargas (string n, int i)
        {
            Nome = n; //valor dinamico
            Idade = i; //valor dinamico
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}