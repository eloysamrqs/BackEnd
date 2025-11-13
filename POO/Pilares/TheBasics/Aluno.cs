
namespace TheBasics
{
    public class Aluno : Pessoa
    {
        //cria um construtor na classe aluno que recebe o endereço
        //chama o construtor da classe mãe(base) e repassa o
        //  endereço para ela 
        public Aluno(Endereco endereco) : base(endereco)
        {
        }
        
        public string RA;
        public float NotaFinal;
        public string Curso;
    }
}
