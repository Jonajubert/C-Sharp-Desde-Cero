# C# Desde Cero

## Capítulo 005 - Condicional if

Hasta ahora nuestros programas ejecutaban las instrucciones una detrás de otra.

En este capítulo aprenderemos a hacer que una parte del código se ejecute solamente cuando se cumple una condición.

Para eso utilizaremos `if`.

---

# ¿Qué aprenderás?

- Qué es una condición.
- Cómo utilizar `if`.
- Qué significa `true`.
- Qué significa `false`.
- Cómo utilizar operadores de comparación.
- Cómo ejecutar código según una condición.

---

# ¿Qué es if?

`if` significa:

> Si se cumple esta condición, ejecutá este código.

Su estructura básica es:

```csharp
if (condicion)
{
    // Código que se ejecutará
}
```

Por ejemplo:

```csharp
int edad = 20;

if (edad >= 18)
{
    Console.WriteLine("Sos mayor de edad.");
}
```

---

# ¿Cómo funciona?

La condición:

```csharp
edad >= 18
```

se evalúa antes de ejecutar el bloque.

Solamente existen dos posibles resultados:

```text
true
false
```

Si obtenemos:

```text
true
```

se ejecutan las instrucciones dentro de `{ }`.

Si obtenemos:

```text
false
```

esas instrucciones se omiten.

---

# Flujo del programa

Podemos representarlo así:

```text
          edad >= 18
              │
              ▼
        ¿Se cumple?
          /       \
       true       false
        │           │
        ▼           ▼
 Ejecutar código   Continuar
```

---

# Ejemplo

Primero declaramos nuestras variables:

```csharp
string nombre;
int edad;
```

Luego solicitamos los datos:

```csharp
Console.Write("Escriba su nombre: ");
nombre = Console.ReadLine();

Console.Write("Escriba su edad: ");
edad = int.Parse(Console.ReadLine());
```

Ahora podemos evaluar la edad:

```csharp
if (edad >= 18)
{
    Console.WriteLine($"Hola {nombre}, sos mayor de edad.");
}
```

---

# Código completo

```csharp
internal class Program
{
    static void Main(string[] args)
    {
        string nombre;
        int edad;

        Console.Write("Escriba su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Escriba su edad: ");
        edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine($"Hola {nombre}, sos mayor de edad.");
        }
    }
}
```

---

# Operadores de comparación

Las condiciones suelen utilizar operadores de comparación.

| Operador | Significado |
|---|---|
| `==` | Igual a |
| `!=` | Distinto de |
| `>` | Mayor que |
| `<` | Menor que |
| `>=` | Mayor o igual |
| `<=` | Menor o igual |

Por ejemplo:

```csharp
edad >= 18
```

significa:

> ¿edad es mayor o igual a 18?

---

# Un detalle importante

No debemos confundir:

```csharp
=
```

con:

```csharp
==
```

`=` se utiliza para asignar un valor:

```csharp
edad = 20;
```

`==` se utiliza para comparar:

```csharp
if (edad == 20)
{
    Console.WriteLine("Tenés 20 años.");
}
```

---

# Ejercicio

Crear un programa que solicite una nota:

```csharp
int nota;

Console.Write("Ingresá una nota: ");
nota = int.Parse(Console.ReadLine());
```

Luego utilizar `if` para mostrar:

```text
Aprobado
```

cuando la nota sea mayor o igual a 6.

---

# Dato importante

`if` no significa que el programa elija aleatoriamente qué hacer.

El programa evalúa una expresión que produce:

```text
true
```

o:

```text
false
```

y decide si ejecuta el bloque según ese resultado.

---

# Próximo paso

Hasta ahora solamente definimos qué ocurre cuando una condición es verdadera.

¿Pero qué hacemos cuando es falsa?

Ese será el siguiente paso al incorporar `else`.
