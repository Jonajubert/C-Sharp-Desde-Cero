using System;

class Program
{
    static void Main()
    {
        // Variables utilizadas en los ejemplos.
        int numero1 = 20;
        int numero2 = 10;

        Console.WriteLine("=== OPERADORES EN C# ===\n");

        
// Repasemos un poco el uso de los comandos de C#
// Console: Permite interactuar con la consola
// .WriteLine: acceder al metodo o propiedad que pertenece a la consola
// En este caso le decimos literalmente a la consola, escribe una linea, en este caso la que esta entre ()

// $: Convertimos el texto en una cadena interpolada, permite insertar variables usando {}
      
      // Operadores aritméticos.
        Console.WriteLine($"Suma: {numero1 + numero2}");
        Console.WriteLine($"Resta: {numero1 - numero2}");
        Console.WriteLine($"Multiplicación: {numero1 * numero2}");
        Console.WriteLine($"División: {numero1 / numero2}");

        Console.WriteLine();

        // Operadores de comparación.
        Console.WriteLine($"¿20 es mayor que 10? {numero1 > numero2}");
        Console.WriteLine($"¿20 es igual a 10? {numero1 == numero2}");

        Console.WriteLine();

        // Operadores lógicos.
        Console.WriteLine($"true && false = {true && false}");
        Console.WriteLine($"true || false = {true || false}");
        Console.WriteLine($"!true = {!true}");
    }
}
