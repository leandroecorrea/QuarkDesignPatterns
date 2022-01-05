using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class AvionAPI : IFlightsProvider
    {
        public void BuscarVuelos(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            Console.WriteLine("============================================");
            Console.WriteLine($"Vuelos encontrados para {destino} desde {origen}.");
            Console.WriteLine($"Fecha ida: {fechaIda} - Fecha vuelta: {fechaVuelta}.");
            Console.WriteLine("============================================");
        }
    }
}
