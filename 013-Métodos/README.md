# C# Desde Cero

## Capítulo 013 - Métodos

**Fecha:** 12/10/2026  
**Tipo:** Concepto  
**Progreso:** 13/40  
**Autor:** Jonatan Jubert — Learning C#

Un método agrupa instrucciones que ejecutamos al llamarlo.
Permite organizar tareas y reutilizar código.

## ¿Qué aprenderemos?

- Definir y llamar métodos.
- Recibir parámetros.
- Diferenciar `void` de un retorno con valor.
- Utilizar `return`.

---

## Un método sin valor de retorno

```csharp
static void Saludar(string nombre)
{
    Console.WriteLine($"Hola, {nombre}!");
}
```

Lo llamamos así:

```csharp
Saludar("Jonatan");
```

`void` indica que no devuelve un valor.
Mostrar texto en consola no equivale a devolver un resultado.

---

## Un método que devuelve un valor

```csharp
static int Sumar(int a, int b)
{
    return a + b;
}
```

Podemos guardar y mostrar el resultado:

```csharp
int resultado = Sumar(5, 3);
Console.WriteLine($"Resultado: {resultado}");
```

`int` indica el tipo de retorno.
`return` devuelve la suma y termina esa llamada al método.

---

## Partes de la definición

| Parte | Función |
| --- | --- |
| `static` | El método pertenece al tipo, no a un objeto concreto. |
| `int` | Tipo del valor devuelto. |
| `Sumar` | Nombre del método. |
| `int a, int b` | Parámetros de entrada. |
| `{ }` | Contienen las instrucciones. |

En este ejemplo, los métodos pertenecen a la clase `Program`.
Los llamamos desde `Main` sin crear un objeto.

## Parámetros y argumentos

En la definición, `a` y `b` son parámetros.

En la llamada `Sumar(5, 3)`, los valores `5` y `3`
son argumentos.

---

## Resultado esperado

El archivo `Program.cs` muestra:

```text
Hola, Jonatan!
Resultado: 8
Otra suma: 15
```

## Cómo ejecutarlo

1. Creá un proyecto de consola C#.
2. Reemplazá su archivo `Program.cs` por el ejemplo.
3. Ejecutá el proyecto.

## Ejercicio

Agregá este método dentro de `Program`, fuera de `Main`:

```csharp
static int Multiplicar(int a, int b)
{
    return a * b;
}
```

Después, llamalo desde `Main`:

```csharp
Console.WriteLine(Multiplicar(4, 5));
```

Resultado esperado: `20`.

## Idea para recordar

Definí la tarea una vez y llamá al método cuando la necesites.

## Documentación

- [Microsoft Learn: métodos](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)
- [Microsoft Learn: void](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/void)
- [Microsoft Learn: static](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static)

Repositorio:
https://github.com/Jonajubert/C-Sharp-Desde-Cero

**Jonatan Jubert — Learning C#**  
Pequeños pasos, grandes resultados.
