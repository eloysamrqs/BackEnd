namespace ExerciciosMetodoConstrutor
{
    public class Funcionario
    {
        public string Nome = "";

        public string Cargo = "";

        public double Salario = 0;


        public Funcionario(string n)
        {
            Nome = n;
            Cargo = "Desconhecido";
            Salario = 0;
        }

        public Funcionario(string n, string c)
        {
            Nome = n;
            Cargo = c;
        }


        public Funcionario(string n, string c, double s)
        {
            Nome = n;
            Cargo = c;
            Salario = s;
        }

        public double calculaBonus() {
        return Salario * 0.10;
    }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} | Cargo: {Cargo} | Salário: {Salario}");
        }
    }
}