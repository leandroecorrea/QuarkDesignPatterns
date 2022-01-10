using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.DAO
{
    public interface CRUD<T>
    {
        List<T> Listar();
    }
}
