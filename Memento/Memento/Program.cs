using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreJuego = "Crash Bandicoot";
            Juego juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 1;

            Caretaker caretaker = new Caretaker();
            Originator originator = new Originator();

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 2;
            originator.Estado = juego;

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 3;
            originator.Estado = juego;

            caretaker.AddMemento(originator.Guardar());

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 4;

            originator.Estado = juego;
            caretaker.AddMemento(originator.Guardar());


            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 5;
            Console.WriteLine(juego);

            originator.Estado = juego;
            originator.Restaurar(caretaker.GetMemento(0));

            juego = originator.Estado;

            Console.WriteLine(juego);


        }
    }
}
