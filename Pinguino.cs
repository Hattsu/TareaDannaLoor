using System;
namespace Tarea_herenciaPOO
{
    class Pinguino:Aves, INadador
    {
        public Pinguino(string nombre, string color):base(nombre, color)
        {
            //atributos heredados de la clase padre
        }
        //Uso del interface
        public void Nadar()
        {
            Console.WriteLine("Nada");
        }
        //Imprimir datos con el metodo heredado
        public void Mostrar_datos()
        {
            Console.WriteLine("................");
            Console.WriteLine("Nombre del ave: "+Nombre);
            Console.WriteLine("Color del ave: "+Color);
            Console.WriteLine("................");
        }
    }
}
