// ==========================================
// C# DESDE CERO
// Capítulo 011 - Arreglos
// ==========================================

internal class Program
{
    static void Main(string[] args)
    {
        // Creamos un arreglo de strings.
        string[] frutas =
        {
            "Manzana",
            "Banana",
            "Naranja"
        };


        // Mostramos el arreglo.
        Console.WriteLine("Frutas:");

        Console.WriteLine(frutas[0]);
        Console.WriteLine(frutas[1]);
        Console.WriteLine(frutas[2]);


        // Modificamos un elemento.
        frutas[1] = "Pera";

        Console.WriteLine("\nArreglo modificado:");

        Console.WriteLine(frutas[0]);
        Console.WriteLine(frutas[1]);
        Console.WriteLine(frutas[2]);


        // Cantidad de elementos.
        Console.WriteLine(
            $"\nCantidad de elementos: {frutas.Length}"
        );


        // Recorremos el arreglo.
        Console.WriteLine("\nRecorriendo con for:");

        for (int i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine(
                $"Índice {i}: {frutas[i]}"
            );
        }
    }
}
