using System;

// ==========================================
// C# DESDE CERO
// Capítulo 013 - Métodos
// ==========================================

class Program
{
    // Punto de entrada del programa.
    static void Main()
    {
        // Llamamos al método con un argumento.
        Saludar("Jonatan");

        // Guardamos el valor que devuelve Sumar.
        int resultado = Sumar(5, 3);
        Console.WriteLine($"Resultado: {resultado}");

        // Reutilizamos el método con otros argumentos.
        Console.WriteLine($"Otra suma: {Sumar(10, 5)}");
    }

    // Recibe un nombre y muestra un saludo.
    // void indica que no devuelve un valor.
    static void Saludar(string nombre)
    {
        Console.WriteLine($"Hola, {nombre}!");
    }

    // Recibe dos enteros y devuelve otro entero.
    static int Sumar(int a, int b)
    {
        return a + b;
    }
}
