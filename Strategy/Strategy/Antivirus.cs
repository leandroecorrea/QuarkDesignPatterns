using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Antivirus
    {
        private IEstrategia _analisis;

        public Antivirus(IEstrategia analisis)
        {
            _analisis = analisis;
        }

        public void Ejecutar()
        {
            _analisis.Analizar();
        }
    }
}
