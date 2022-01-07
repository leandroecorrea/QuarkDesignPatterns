using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Invoker
    {
        private List<IOperacion> _operaciones = new List<IOperacion>();
        public void RecibirOperacion(IOperacion operacion) => _operaciones.Add(operacion);
        public void RealizarOperaciones()
        {
            _operaciones.ForEach(o => o.Ejecutar());
            _operaciones.Clear();
        }
    }
}
