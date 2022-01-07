using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        public Juego Estado { get; }
        public Memento(Juego estado)
        {
            Estado = estado;
        }
    }
}
