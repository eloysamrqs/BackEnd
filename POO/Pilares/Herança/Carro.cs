namespace Herança
{
        public class Carro : Veiculo
    {
        public int qntPortas = 0;
        public override void MostrarInfo()
        {
            Console.WriteLine(@$"Modelo: {Modelo}
                                 Marca: {Marca}
                                 Portas: {qntPortas}");
        }
    }
}