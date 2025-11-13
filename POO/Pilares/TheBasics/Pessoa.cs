//namespace pode ser considerado como a pasta do projeto
//namespace é o módulo do sistema
//namespace é como um pacote,

using System.ComponentModel.DataAnnotations;

namespace TheBasics
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        
        public Endereco EnderecoCompleto;

        //construtor
        public Pessoa ( Endereco endereco)
        {
            EnderecoCompleto = endereco;
        }

        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou o(a) {Nome} e tenho {Idade} anos");
        }

        public void Envelhecer()
        {
            Idade++;
        }
    }
}