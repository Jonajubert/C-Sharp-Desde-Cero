internal class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // C# DESDE CERO
        // Capítulo 010 - Bucle for
        // ==========================================


        // EJEMPLO 1
        // Mostrar los números del 1 al 5.

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Número: {i}");
        }


        Console.WriteLine();


        // EJEMPLO 2
        // Contar de forma descendente.

        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine($"Cuenta regresiva: {i}");
        }


        Console.WriteLine();


        // EJEMPLO 3
        // Recorrer un arreglo.

        string[] frutas =
        {
            "Manzana",
            "Banana",
            "Naranja",
            "Uva"
        };

        for (int i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine(frutas[i]);
        }
    }
}
