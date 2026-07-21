using System;

namespace CSharpDesdeCero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------
            // TIPOS DE DATOS EN C#
            // ----------------------------------------------------

            // Variable de tipo texto.
            string nombre = "Jonatan";

            // Variable de tipo entero.
            int edad = 30;

            // Variable de tipo decimal.
            double altura = 1.75;

            // Variable de tipo verdadero o falso.
            bool esProgramador = true;

            // Variable que almacena un único carácter.
            char inicial = 'J';

            Console.WriteLine("=== TIPOS DE DATOS ===");
            Console.WriteLine();

            // Imprimimos cada variable.
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("¿Es programador?: " + esProgramador);
            Console.WriteLine("Inicial: " + inicial);

            Console.ReadKey();
        }
    }
}
