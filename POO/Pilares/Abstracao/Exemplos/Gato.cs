using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Gatinho miau miau :) ");
        }

        public override void Mover()
        {
            Console.WriteLine($"Movendo as patinhas");
        }
    }
}