using System;

namespace Facade
{
    class Program
    {

        static void Main(string[] args)
        {
            AvionAPI avionAPI = new AvionAPI();
            HotelAPI hotelAPI = new HotelAPI();
            CheckFacade clienteA = new CheckFacade(avionAPI, hotelAPI);
            clienteA.Buscar("01/06/2022", "08/06/2022", "Buenos Aires", "Mar del Plata");
        }       
    }
}
