using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject
    {
        private List<IObservador> observadores = new List<IObservador>();
        private int _estado;       

        public void SetEstado(int estado)
        {
            _estado = estado;
            NotificarObservadores();
        }

        public void AgregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        private void NotificarObservadores() => observadores.ForEach(o => o.Actualizar(_estado));        
    }
}
