namespace Exercicio2
{
    public class Relatorio : IImprimivel 
    {
        public string Nome;
        public string TextoRelatorio = "";

        //Sobrecarga do construtor
        public Relatorio( string responsavel, string txtRelatorio )
        {
            Nome = responsavel;
            TextoRelatorio = txtRelatorio;
        }


    public void Imprimir()
    {
        Console.WriteLine($"Responsável: {Nome}...");
        Console.WriteLine(TextoRelatorio);
        Console.WriteLine($"-----------------------");
    }
    }
}
