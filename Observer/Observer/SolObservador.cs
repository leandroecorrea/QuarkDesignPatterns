using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class SolObservador : IObservador
    {
        private float ValorDeCambio = 3.25f;

        public void Actualizar(int estado)
        {
            Console.WriteLine($"SOL: {estado * ValorDeCambio}");
        }
    }
}
