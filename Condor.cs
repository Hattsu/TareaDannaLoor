using System;
namespace Tarea_herenciaPOO
{
    class Condor:Aves, IVolador
    {
        public Condor(string nombre, string color):base(nombre, color)
        {
            //atributos  que van a ser heredados
        }
        //uso del interface
        public void Volar()
        {
            Console.WriteLine("Vuela");
        }
        //Metodo heredado de la clase padre
        public void Mostrar_datos()
        {
            Console.WriteLine("................");
            Console.WriteLine("Nombre del ave: "+Nombre);
            Console.WriteLine("Color del ave: "+Color);
            Console.WriteLine("................");
        }
    }
}
