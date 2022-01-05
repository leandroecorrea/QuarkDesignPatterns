using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HotelAPI : IHotelsProvider
    {
        public void BuscarHoteles(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            Console.WriteLine("============================================");
            Console.WriteLine($"Hoteles encontrados en {destino}.");
            Console.WriteLine($"Entrada: {fechaIda} - Saluda: {fechaVuelta}.");
            Console.WriteLine("Hotel A");
            Console.WriteLine("Hotel B");
            Console.WriteLine("Hotel C");
            Console.WriteLine("============================================");
        }
    }
}
