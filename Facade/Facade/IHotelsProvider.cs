using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public interface IHotelsProvider
    {
        public void BuscarHoteles(string fechaIda, string fechaVuelta, string origen, string destino);
    }
}
