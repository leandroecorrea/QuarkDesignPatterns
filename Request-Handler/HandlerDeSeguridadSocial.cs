public class HandlerDeSeguridadSocial : IHandlerDeTramites
{
    public void Handle(Empleado empleado)
    {
        Console.WriteLine($"El empleado {empleado.Nombre} fue registrado en ANSES");
    }
}