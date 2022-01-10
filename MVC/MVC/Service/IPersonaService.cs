using MVC.DAO;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Service
{
    interface IPersonaService : CRUD<Persona>
    {
    }
}
