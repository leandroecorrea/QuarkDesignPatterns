using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class AnalisisAvanzado : IEstrategia
    {        

        public void Analizar()
        {
            Iniciar();
            AnalizarMemoria();
            AnalizarKeyloggers();
            AnalizarRootkits();
            DescomprimirZip();
            Detener();
        }

        private void Iniciar()
        {
            Console.WriteLine("Antivirus - Análisis avanzado iniciado");
        }

        private void AnalizarMemoria()
        {
            try
            {
                Console.WriteLine("Analizando Memoria RAM...");                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void AnalizarKeyloggers()
        {
            try
            {
                Console.WriteLine("Analizando en busca de Keyloggers...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void AnalizarRootkits()
        {
            try
            {
                Console.WriteLine("Analizando en busca de RootKits...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void DescomprimirZip()
        {
            try
            {
                Console.WriteLine("Analizando archivos zip...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private void Detener()
        {
            Console.WriteLine("Antivirus - Análisis avanzado finalizado");
        }

    }
}
