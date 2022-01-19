public class HandlerDeAltas : IHandlerDeTramites
{
    public void Handle(Empleado empleado)
    {
        Console.WriteLine($"El empleado {empleado.Nombre} fue dado de alta en la empresa");
    }
}