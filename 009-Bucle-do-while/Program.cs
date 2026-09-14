internal class Program
{
    static void Main(string[] args)
    {
        // Declaramos e inicializamos el contador.
        int contador = 1;

        // Ejecutamos el bloque al menos una vez.
        do
        {
            Console.WriteLine($"Número: {contador}");

            contador++;
        }
        while (contador <= 5);

        Console.WriteLine("Fin del programa.");
    }
}
