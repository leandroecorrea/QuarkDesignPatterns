using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CheckFacade
    {
        private IFlightsProvider flights;
        private IHotelsProvider hotels;

        public CheckFacade(IFlightsProvider flights, IHotelsProvider hotels)
        {
            this.flights = flights;
            this.hotels = hotels;
        }

        public void Buscar(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            flights.BuscarVuelos(fechaIda, fechaVuelta, origen, destino);
            hotels.BuscarHoteles(fechaIda, fechaVuelta, origen, destino);
        }
    }
}
