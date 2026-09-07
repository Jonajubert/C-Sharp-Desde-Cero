internal class Program
{
    static void Main(string[] args)
    {
        // Declaramos e inicializamos el contador.
        int contador = 1;

        // Repetimos mientras la condición sea verdadera.
        while (contador <= 5)
        {
            // Mostramos el valor actual.
            Console.WriteLine(contador);

            // Incrementamos el contador.
            contador++;
        }

        // Esta instrucción se ejecuta
        // cuando termina el bucle.
        Console.WriteLine("Fin del programa.");
    }
}
