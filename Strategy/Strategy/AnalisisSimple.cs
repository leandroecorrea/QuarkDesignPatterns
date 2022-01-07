using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class AnalisisSimple : IEstrategia
    {
        public void Analizar()
        {
            Iniciar();
            SaltarZip();
            Detener();
        }

        private void Iniciar()
        {
            Console.WriteLine("Antivirus - Análisis simple iniciado");           
        }

        private void SaltarZip()
        {
            try
            {
                Console.WriteLine("Analizando...");
                Console.WriteLine("No se pudo analizar archivos con extensión '.zip'");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private void Detener()
        {
            Console.WriteLine("Antivirus Simple - Análisis simple finalizado");
        }
    }
}
