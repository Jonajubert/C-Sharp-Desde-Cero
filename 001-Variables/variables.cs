using System;

namespace CSharpDesdeCero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------
            // VARIABLES EN C#
            // ---------------------------------------------

            // Declaramos una variable de tipo texto (string)
            // Esta variable almacenará un nombre.
            string nombre = "Jonatan";

            // Declaramos una variable de tipo entero (int)
            // Esta variable almacenará una edad.
            int edad = 30;

            // Imprimimos un título en la consola.
            Console.WriteLine("=== VARIABLES EN C# ===");

            // Imprimimos el contenido de la variable "nombre".
            Console.WriteLine("Nombre: " + nombre);

            // Imprimimos el contenido de la variable "edad".
            Console.WriteLine("Edad: " + edad);

            // Esperamos una tecla antes de cerrar la aplicación.
            Console.ReadKey();
        }
    }
}
