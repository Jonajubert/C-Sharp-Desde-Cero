internal class Program
{
    static void Main(string[] args)
    {
        // Declaramos las variables.
        string nombre;
        int edad;

        // Solicitamos el nombre.
        Console.Write("Escriba su nombre: ");
        nombre = Console.ReadLine();

        // Solicitamos la edad.
        Console.Write("Escriba su edad: ");
        edad = int.Parse(Console.ReadLine());

        // Evaluamos la condición.
        if (edad >= 18)
        {
            Console.WriteLine($"Hola {nombre}, sos mayor de edad.");
        }
    }
}
