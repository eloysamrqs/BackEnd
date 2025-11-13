namespace ExerciciosMetodoConstrutor
{
    public class Computador
    {
        public string Marca = "";

        public int MemoriaRam = 0;

        public int Armazenamento = 0;

        public Computador(string M, int MR, int A)
        {
            Marca = M;
            MemoriaRam = MR;
            Armazenamento = A;
        }

        public Computador()
        {
            Marca = "Desconhecida";
            MemoriaRam = 0;
            Armazenamento = 0;
        }
    }
}