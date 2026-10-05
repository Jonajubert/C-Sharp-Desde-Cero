# 012 — Listas en C#

Una lista permite almacenar varios elementos de un mismo tipo y agregar o quitar elementos durante la ejecución.

En `List<T>`, la `T` representa el tipo de dato que guardamos.

## Ejemplo de código

```csharp
List<string> productos = new List<string>
{
    "Arroz",
    "Leche",
    "Pan"
};

productos.Add("Yerba");
productos.Remove("Leche");

foreach (string producto in productos)
{
    Console.WriteLine(producto);
}

Console.WriteLine($"Cantidad: {productos.Count}");
```

## Operaciones básicas

| Operación | Ejemplo | Resultado |
| --- | --- | --- |
| Agregar al final | `productos.Add("Yerba")` | Incorpora un elemento |
| Acceder por índice | `productos[0]` | Obtiene el primer elemento |
| Buscar un valor | `productos.Contains("Pan")` | Devuelve `true` o `false` |
| Eliminar por valor | `productos.Remove("Leche")` | Quita la primera coincidencia |
| Consultar la cantidad | `productos.Count` | Indica cuántos elementos hay |
| Recorrer | `foreach` | Permite procesar cada elemento |

Los índices comienzan en **0**. Antes de acceder a una posición, debe existir un elemento en ella.

## Cómo ejecutar

1. Creá una aplicación de consola de C#.
2. Reemplazá el contenido de `Program.cs` por el código de este capítulo.
3. Ejecutá el proyecto.

## Probalo vos

1. Agregá dos productos nuevos.
2. Mostrá el último producto usando `productos[productos.Count - 1]`.
3. Comprobá si existe `"Arroz"` con `Contains()`.
4. Eliminá un producto y volvé a mostrar la cantidad.

## Idea para recordar

Usá `Count` para conocer la cantidad de elementos de una lista.
El último índice válido es `Count - 1`, siempre que la lista no esté vacía.

## Documentación de referencia

[List<T> — Microsoft Learn](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1)

---

Jonatan Jubert — Learning C#
