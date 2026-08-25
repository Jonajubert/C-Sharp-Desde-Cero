internal class Program
{
    static void Main(string[] args)
    {
        // Declaramos las variables.
        string nombre;
        int nota;

        // Solicitamos los datos.
        Console.Write("Escriba su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su nota: ");
        nota = int.Parse(Console.ReadLine());

        // Evaluamos la nota.
        if (nota >= 9)
        {
            Console.WriteLine($"Excelente, {nombre}.");
        }
        else if (nota >= 6)
        {
            Console.WriteLine($"Aprobaste, {nombre}.");
        }
        else
        {
            Console.WriteLine($"Desaprobaste, {nombre}.");
        }
    }
}
