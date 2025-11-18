namespace Exercicio2
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        //Sobrecarga do construtor - obriga a passar os dados na criação objeto
        public Fatura ( string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }

        public void Imprimir()
        {
            CalcularValorDivida();
            //Calcular o juros antes de usar o valor da fatura
            Console.WriteLine($@"
            Credor: {Credor}
            Devedor: {Devedor}
            Dias de atraso: {DiasDeAtraso} dia(s)
            Valor: R${Valor:F2}
            Juros: R${ (Juros * DiasDeAtraso):F2}
            Total com juros: R${Valor:F2}
            ");
        }


        public void CalcularValorDivida()
        {
            if (DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }

            if (DiasDeAtraso >= 5)
            {
                Console.WriteLine($"Divida encaminhada para o SERASA");
            }	
        }
    }
}