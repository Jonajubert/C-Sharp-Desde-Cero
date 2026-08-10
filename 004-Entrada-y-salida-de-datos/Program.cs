// ==========================================
// C# DESDE CERO
// Capítulo 004 - Entrada y salida de datos
// ==========================================


// Mostramos un mensaje en la consola.
Console.WriteLine("=== DATOS PERSONALES ===");


// Solicitamos el nombre al usuario.
Console.Write("Ingresá tu nombre: ");

// Console.ReadLine() permite leer lo que
// el usuario escribe en la consola.
string nombre = Console.ReadLine() ?? "";


// Solicitamos la edad.
Console.Write("Ingresá tu edad: ");

// ReadLine devuelve texto.
// int.Parse convierte ese texto a un número entero.
int edad = int.Parse(Console.ReadLine() ?? "0");


// Mostramos los datos utilizando interpolación.
Console.WriteLine();
Console.WriteLine("=== RESULTADO ===");

Console.WriteLine($"Hola, {nombre}!");
Console.WriteLine($"Tenés {edad} años.");
