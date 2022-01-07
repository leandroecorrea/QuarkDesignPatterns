using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class PesoMEXObservador : IObservador
    {
        private float ValorDeCambio = 19.07f;

        public void Actualizar(int estado)
        {
            Console.WriteLine($"MEX: {estado * ValorDeCambio}");
        }
    }
}
