using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Juego
    {
        public string Nombre { get; set; }
        public int Checkpoint { get; set; }
        public override string ToString() => $"Juego [nombre= {Nombre}, checkpoint= {Checkpoint}]";
    }
}
