using System;
namespace Tarea_herenciaPOO
{
    class Aves
    {
        public string Nombre{set; get;}
        public string Color{set; get;}

        public Aves (string nombre, string color)
        {
            this.Nombre = nombre;
            this.Color = color;
        }

        public void Imprimir_datos()
        {
            Console.WriteLine("................");
            Console.WriteLine("Nombre del ave: "+Nombre);
            Console.WriteLine("Color del ave: "+Color);
            Console.WriteLine("................");
        }

    }
}
