using MVC.DAO;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Service
{
    public class PersonaServiceImpl : IPersonaService
    {
        private PersonaDAO _dao;

        public PersonaServiceImpl(PersonaDAO personaDAO)
        {
            _dao = personaDAO;
        }

        public List<Persona> Listar()
        {
            return _dao.Listar();
        }
    }
}
