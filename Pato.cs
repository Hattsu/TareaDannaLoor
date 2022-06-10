using System;
namespace Tarea_herenciaPOO
{
    class Pato:Aves, INadador
    {
        public Pato(string nombre, string color):base(nombre, color)
        {
            //atributos heredados de la clase padre
        }
        //Uso del interface
        public void Nadar()
        {
            Console.WriteLine("Nada");
        }
        // Imprimir datos
        public void Mostrar_datos()
        {
            Console.WriteLine("................");
            Console.WriteLine("Nombre del ave: "+Nombre);
            Console.WriteLine("Color del ave: "+Color);
            Console.WriteLine("................");
        }
    }
}
