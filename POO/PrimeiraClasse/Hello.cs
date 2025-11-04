namespace PrimeiraClasse
{
    public class Hello
    {
        // PROPRIEDADES/CARCATERISICAS - VARIAVESIS INTERNAS DESSA CLASSE
        public string TextoHello = "";

        //METODOS/COMPORTAMENTOS/ACOES -  SAO AS FUNCOES INTERNAS DESSA CLASSE
        public void SaudarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }

        public void SaudarComNome (string n)
        {
            Console.WriteLine ($"Ola {n}");
        }
    }
}