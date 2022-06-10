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
        //Metodo para imprimir datos
        public void Mostrar_datos()
        {
            Console.WriteLine("................");
            Console.WriteLine("Nombre del ave: "+Nombre);
            Console.WriteLine("Color del ave: "+Color);
            Console.WriteLine("................");
        }

    }
}
