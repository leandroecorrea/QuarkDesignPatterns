public class MediadorDeSolicitudes
{
    private List<IHandlerDeTramites> HandlerDeTramites;

    public MediadorDeSolicitudes()
    {
        HandlerDeTramites = new List<IHandlerDeTramites>();
    }

    public void RegistrarHandler(IHandlerDeTramites handler)
    {
        HandlerDeTramites.Add(handler);
    }

    public void EliminarHandler(IHandlerDeTramites handler)
    {
        HandlerDeTramites.Remove(handler);
    }

    public void RealizarTramites(ITramitesDeEmpleados solicitudDeEmpleado)
    {
        foreach(var handler in HandlerDeTramites)
        {
            handler.Handle(solicitudDeEmpleado.Empleado);
        }
    }
}