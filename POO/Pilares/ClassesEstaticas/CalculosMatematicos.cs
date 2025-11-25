using System.Net.WebSockets;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        // Operações matemáticas simples
        // Visibilidade tipoDeRetorno Nome(parâmetros) {corpo}
        public static float Somar(float a, float b)
        {
            return a + b;
        }

        public static float Subtrair(float a, float b)
        {
            return a - b;
        }

        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        public static float Dividir(float a, float b)
        {
            if (b == 0)
            {
               Console.WriteLine($"Divisão por zero não é permitida.");
            }
             return a / b;
        }
    }
}