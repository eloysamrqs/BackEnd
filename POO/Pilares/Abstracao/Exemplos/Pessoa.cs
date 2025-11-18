using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public abstract class Pessoa : Animal
    {
        public string Nome;
        public int Idade;

        public abstract void Dormir();
    }
}