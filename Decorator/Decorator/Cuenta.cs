using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string Cliente { get; set; }

        public Cuenta(int id, string cliente)
        {
            Id = id;
            Cliente = cliente;
        }
        public Cuenta()
        {

        }
    }
}
