using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            PesoARGObservador pesoArgentino = new PesoARGObservador();
            PesoMEXObservador pesoMexicano = new PesoMEXObservador();
            SolObservador solPeruano = new SolObservador();

            Subject sujetoObservado = new Subject();
            sujetoObservado.AgregarObservador(pesoArgentino);
            sujetoObservado.AgregarObservador(pesoMexicano);
            sujetoObservado.AgregarObservador(solPeruano);

            sujetoObservado.SetEstado(100);
        }
    }
}
