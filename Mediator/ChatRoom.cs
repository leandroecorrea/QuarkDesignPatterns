public class ChatRoom
{
    private IList<Usuario> usuarios;
    public ChatRoom()
    {
        usuarios = new List<Usuario>();
    }

    public void AgregarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
        usuario.MensajeTransmitido += Mensajero;
    }

    public void RemoverUsuario(Usuario usuario)
    {
        usuario.MensajeTransmitido -= Mensajero;
        Mensajero(usuario, $"{usuario.Nombre} se desconectó de la sala");
        usuarios.Remove(usuario);
    }

    protected void Mensajero(Usuario emisor, string mensaje)
    {
        var usuariosInteresados = usuarios.Where(u=> u != emisor);
        foreach(Usuario usuarioInteresado in usuariosInteresados)
        {
            usuarioInteresado.RecibirMensaje(emisor, mensaje);
        }
    }



}