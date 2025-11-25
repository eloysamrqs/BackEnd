namespace Encapsulamento
{
    public class Carro 
    {
        private string modelo = "";
        private string marca = "";
        private int velocidadeAtual;

        public void DefinirMarca(string M)
        {
            marca = M;
        }

        public string ObterMarca()
        {
            return marca;
        }

        public void DefinirModelo(string Mo)
        {
            modelo = Mo;
        }

        public string ObterModelo()
        {
            return modelo;
        }

        public void Acelerar(int quantidade)
        {
            velocidadeAtual += quantidade;
        }

        public int ObterVelocidade()
        {
            return velocidadeAtual;
        }

        public void Frear(int quantidade)
        {
            velocidadeAtual -= quantidade;
            if (velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }
        }
    }
}