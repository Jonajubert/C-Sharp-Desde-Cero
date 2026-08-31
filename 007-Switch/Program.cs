internal class Program
{
    static void Main(string[] args)
    {
        // Declaramos la variable.
        int opcion;

        // Mostramos el menú.
        Console.WriteLine("=== MENÚ PRINCIPAL ===");
        Console.WriteLine("1 - Consultar saldo");
        Console.WriteLine("2 - Realizar transferencia");
        Console.WriteLine("3 - Salir");

        // Solicitamos una opción.
        Console.Write("Seleccione una opción: ");
        opcion = int.Parse(Console.ReadLine());

        // Evaluamos la opción seleccionada.
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Consultando saldo...");
                break;

            case 2:
                Console.WriteLine("Iniciando transferencia...");
                break;

            case 3:
                Console.WriteLine("Saliendo del programa...");
                break;

            default:
                Console.WriteLine("Opción incorrecta.");
                break;
        }
    }
}
