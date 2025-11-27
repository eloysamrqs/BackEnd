namespace Encapsulamento
{
    public class Carro 
    {
        private string modelo = "";
        private string marca = "";
        private int velocidadeAtual;

        public void DefinirMarca(string valor)
        {
            marca = valor;
        }

        public string ObterMarca()
        {
            return marca;
        }

        public void DefinirModelo(string valor)
        {
            modelo = valor;
        }

        public string ObterModelo()
        {
            return modelo;
        }

        public int ObterVelocidade()
        {
            return velocidadeAtual;
        }

        public void Acelerar(int quantidade)
        {
            if (quantidade > 0) velocidadeAtual += quantidade;
        }

        public void Frear(int quantidade)
        {
            if (quantidade > 0) 
            {
                velocidadeAtual -= quantidade;
            }
        }
    }
}