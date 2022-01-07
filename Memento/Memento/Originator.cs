using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Originator
    {
        public Juego Estado { get; set; }
        public Memento Guardar() => new Memento(Estado);
        public void Restaurar(Memento memento) => Estado = memento.Estado;
    }
}
