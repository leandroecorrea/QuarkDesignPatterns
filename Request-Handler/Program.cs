// See https://aka.ms/new-console-template for more information
var mediador = new MediadorDeSolicitudes();
mediador.RegistrarHandler(new HandlerDeAltas());
mediador.RegistrarHandler(new HandlerDeSeguridadSocial());
var empleado1 = new Empleado("Leandro");
ITramitesDeEmpleados tramitesDeEmpleados = new TramitesDeEmpleados(empleado1);
mediador.RealizarTramites(tramitesDeEmpleados);
