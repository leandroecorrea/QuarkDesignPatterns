using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class PesoARGObservador : IObservador
    {
        private float ValorDeCambio = 103.22f;
        
        public void Actualizar(int estado)
        {
            Console.WriteLine($"ARG: {estado * ValorDeCambio}");
        }
    }
}
