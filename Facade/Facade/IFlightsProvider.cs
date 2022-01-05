using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public interface IFlightsProvider
    {
        public void BuscarVuelos(string fechaIda, string fechaVuelta, string origen, string destino);
    }
}
