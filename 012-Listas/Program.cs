using System;
using System.Collections.Generic;

// Creamos una lista con tres productos.
List<string> productos = new List<string>
{
    "Arroz",
    "Leche",
    "Pan"
};

// Agregamos un producto al final.
productos.Add("Yerba");

// Accedemos al primer elemento: el índice comienza en 0.
Console.WriteLine($"Primer producto: {productos[0]}");

// Comprobamos si un producto está en la lista.
if (productos.Contains("Pan"))
{
    Console.WriteLine("Pan está en la lista.");
}

// Eliminamos la primera coincidencia de este valor.
productos.Remove("Leche");

// Recorremos la lista después de modificarla.
Console.WriteLine("\nProductos:");

foreach (string producto in productos)
{
    Console.WriteLine($"- {producto}");
}

// Count indica la cantidad actual de elementos.
Console.WriteLine($"\nCantidad de productos: {productos.Count}");
