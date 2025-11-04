namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
 
        //Metodo construtor Pessoa
        //pssui parametros - representam os valores de nome e idade
        //ou seja, estamos inicializando os valores para as propriedades
        //nome e idade
        public Pessoa (string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}