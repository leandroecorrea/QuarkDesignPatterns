public delegate void Mensajero(Usuario usuario, string mensaje);
public class Usuario
{
    public event Mensajero MensajeTransmitido;

    public string Nombre { get; }
    public Usuario(string nombre)
    {
        Nombre = nombre;
    }

    public void EnviarMensaje(string mensaje)
    {
        TransmitirMensaje(mensaje);
    }

    public void RecibirMensaje(Usuario emisor, string mensaje)
    {
        Console.WriteLine($"{Nombre} recibió un mensaje de {emisor.Nombre}: {mensaje}");
    }
    protected void TransmitirMensaje(string mensaje)
    {
        MensajeTransmitido?.Invoke(this, mensaje);
    }
}