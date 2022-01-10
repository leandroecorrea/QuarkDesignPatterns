using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.DAO;
using MVC.Models;
using MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class PersonaController : Controller
    {
        public List<Persona> Lista { get; set; }
        private IPersonaService _service;
        private string _motor;
        private ILogger<PersonaController> _logger;

        public PersonaController(ILogger<PersonaController> logger)
        {
            _logger = logger;
            _motor = "MYSQL";
            Lista = new List<Persona>();
            _service = new PersonaServiceImpl(new PersonaDAOImpl(_motor));
            Listar();
        }

        public IActionResult Index()
        {
            return View("Persona", Lista);
        }

        public void Listar()
        {
            Lista = _service.Listar();
        }

        public IActionResult Seleccionar(string motor)
        {
            _service = new PersonaServiceImpl(new PersonaDAOImpl(motor));
            Listar();            
            return Index();
        }
    }
}
