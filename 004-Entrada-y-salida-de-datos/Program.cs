internal class Program
{
    static void Main(string[] args)
    {
        // Declaramos una variable de tipo string.
        string nombre;

        // Mostramos un mensaje solicitando el nombre.
        Console.Write("Escriba su nombre: ");

        // Leemos lo escrito por el usuario
        // y lo guardamos en la variable nombre.
        nombre = Console.ReadLine();

        // Mostramos un saludo con el dato almacenado.
        Console.WriteLine($"Hola + {nombre}.");

    }
}
