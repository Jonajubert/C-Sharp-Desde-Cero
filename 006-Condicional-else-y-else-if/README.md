# C# Desde Cero

## Capítulo 006 - Condicional else y else if

En el capítulo anterior aprendimos a utilizar `if`.

Ahora vamos a ampliar nuestras estructuras condicionales utilizando:

```csharp
else
else if
```

Esto nos permitirá crear programas con varios caminos posibles.

---

# ¿Qué aprenderás?

- Cómo utilizar `else`.
- Cómo utilizar `else if`.
- Cómo evaluar varias condiciones.
- Cómo funciona el orden de evaluación.
- Cómo construir diferentes caminos dentro de un programa.

---

# Recordemos if

Con `if` ejecutamos código solamente cuando una condición es verdadera.

```csharp
int edad = 20;

if (edad >= 18)
{
    Console.WriteLine("Sos mayor de edad.");
}
```

Pero si `edad` vale `16`, el bloque simplemente no se ejecuta.

¿Y si queremos hacer algo también en ese caso?

---

# else

`else` permite ejecutar otro bloque cuando la condición del `if` es falsa.

```csharp
int edad = 16;

if (edad >= 18)
{
    Console.WriteLine("Sos mayor de edad.");
}
else
{
    Console.WriteLine("Sos menor de edad.");
}
```

Podemos visualizarlo así:

```text
           edad >= 18
                │
          ┌─────┴─────┐
          │           │
        true        false
          │           │
          ▼           ▼
         IF          ELSE
```

---

# else if

¿Qué ocurre si tenemos más de dos posibilidades?

Podemos utilizar `else if`.

```csharp
if (nota >= 9)
{
    Console.WriteLine("Excelente");
}
else if (nota >= 6)
{
    Console.WriteLine("Aprobado");
}
else
{
    Console.WriteLine("Desaprobado");
}
```

Ahora tenemos tres caminos posibles.

---

# ¿Cómo se evalúa?

Supongamos:

```csharp
int nota = 8;
```

Primero C# evalúa:

```text
nota >= 9
8 >= 9
false
```

Continúa con:

```text
nota >= 6
8 >= 6
true
```

Entonces ejecuta:

```text
Aprobado
```

y termina esa cadena condicional.

---

# El orden importa

Observemos:

```csharp
if (nota >= 9)
{
    Console.WriteLine("Excelente");
}
else if (nota >= 6)
{
    Console.WriteLine("Aprobado");
}
```

Una nota `10` cumple ambas condiciones.

Pero C# encuentra primero:

```text
10 >= 9 → true
```

y ejecuta solamente ese bloque.

Por eso obtenemos:

```text
Excelente
```

---

# Cuidado con este orden

Si escribimos:

```csharp
if (nota >= 6)
{
    Console.WriteLine("Aprobado");
}
else if (nota >= 9)
{
    Console.WriteLine("Excelente");
}
```

para:

```text
nota = 10
```

la primera condición ya es verdadera:

```text
10 >= 6 → true
```

Por lo tanto:

```text
Aprobado
```

El segundo bloque nunca será alcanzado en esa cadena.

---

# Estructura general

Podemos pensarla así:

```csharp
if (condicion1)
{
    // Primera posibilidad
}
else if (condicion2)
{
    // Segunda posibilidad
}
else
{
    // Ninguna condición anterior
}
```

No siempre necesitamos utilizar las tres partes.

Podemos tener:

```text
if
```

o:

```text
if + else
```

o:

```text
if + else if + else
```

dependiendo del problema.

---

# Código completo

```csharp
internal class Program
{
    static void Main(string[] args)
    {
        string nombre;
        int nota;

        Console.Write("Escriba su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su nota: ");
        nota = int.Parse(Console.ReadLine());

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
```

---

# Ejercicio

Crear un programa que solicite una temperatura.

Mostrar:

```text
30 o más       → Hace calor
Entre 15 y 29  → Temperatura agradable
Menos de 15    → Hace frío
```

Intentá resolverlo utilizando:

```csharp
if
else if
else
```

---

# Dato importante

Las condiciones de una cadena:

```csharp
if
else if
else
```

se evalúan en orden.

Cuando una condición es verdadera, se ejecuta su bloque y se omiten los restantes de esa cadena.

Por eso el orden de nuestras condiciones puede cambiar el resultado del programa.

---

# Próximo capítulo

Ya podemos hacer que nuestros programas elijan entre varios caminos.

En los próximos capítulos seguiremos incorporando herramientas para controlar cada vez mejor el flujo de ejecución.
