using System;
namespace Tarea_herenciaPOO
{
    class Gallina:Aves, IVolador
    {
        public Gallina(string nombre, string color):base(nombre, color)
        {
            //atributos heredados de la clase padre
        }
        //uso del interface 
        public void Volar()
        {
            Console.WriteLine("Vuela");
        }
        
        // Imprimir los datos
        public void Mostrar_datos()
        {
            Console.WriteLine("................");
            Console.WriteLine("Nombre del ave: "+Nombre);
            Console.WriteLine("Color del ave: "+Color);
            Console.WriteLine("................");
        }
    }
}
