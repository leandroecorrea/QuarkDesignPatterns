// See https://aka.ms/new-console-template for more information
Usuario juan = new Usuario("Juan");
Usuario pepe = new Usuario("Pepe");
Usuario goku = new Usuario("Goku123");
ChatRoom chatTerra = new ChatRoom();
chatTerra.AgregarUsuario(juan);
chatTerra.AgregarUsuario(goku);
chatTerra.AgregarUsuario(pepe);
juan.EnviarMensaje("Hola, como están?");
goku.EnviarMensaje("Hola, soy Goku");
pepe.EnviarMensaje("jajajaja");
chatTerra.RemoverUsuario(goku);
juan.EnviarMensaje("bue");
goku.EnviarMensaje("hola?");
