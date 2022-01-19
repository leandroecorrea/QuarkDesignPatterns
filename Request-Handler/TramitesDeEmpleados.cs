public class TramitesDeEmpleados : ITramitesDeEmpleados
{
    public Empleado Empleado {get;}
    public TramitesDeEmpleados(Empleado empleado)
    {
        Empleado = empleado;
    }
}