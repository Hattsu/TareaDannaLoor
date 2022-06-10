using System;
namespace Tarea_herenciaPOO
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Constructor
            Condor condor = new Condor("Condor-Juan", "Negro");
            condor.Mostrar_datos();
            condor.Volar();
            //Constructor
            Gallina gallina = new Gallina("Gallina-Maria", "Café");
            gallina.Mostrar_datos();
            gallina.Volar();
            //Constructor
            Pinguino pinguino= new Pinguino("Pinguino-Pepe", "Negro");
            pinguino.Mostrar_datos();
            pinguino.Nadar();
            //Constructor
            Pato pato = new Pato("Pato-Roco", "Blanco");
            pato.Mostrar_datos();
            pato.Nadar();
        }
    }
}
