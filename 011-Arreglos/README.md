# C# Desde Cero

## Capítulo 011 - Arreglos

Hasta ahora utilizamos variables para almacenar valores individuales.

Por ejemplo:

```csharp
string fruta1 = "Manzana";
string fruta2 = "Banana";
string fruta3 = "Naranja";
```

Cuando necesitamos almacenar varios valores del mismo tipo, podemos utilizar un:

```text
ARREGLO
```

---

## ¿Qué es un arreglo?

Un arreglo permite almacenar varios elementos del mismo tipo dentro de una sola variable.

Por ejemplo:

```csharp
string[] frutas =
{
    "Manzana",
    "Banana",
    "Naranja"
};
```

Tenemos una variable:

```text
frutas
```

que contiene tres valores.

---

## Declarar un arreglo

La sintaxis:

```csharp
string[] frutas;
```

indica que `frutas` será un arreglo de:

```text
string
```

También podemos crearlo directamente:

```csharp
string[] frutas =
{
    "Manzana",
    "Banana",
    "Naranja"
};
```

Para números:

```csharp
int[] numeros =
{
    10,
    20,
    30,
    40
};
```

Todos los elementos deben ser compatibles con el tipo declarado.

---

# Índices

Cada elemento tiene una posición denominada índice.

C# comienza a contar desde:

```text
0
```

Por ejemplo:

```text
ÍNDICE       ELEMENTO

0            Manzana
1            Banana
2            Naranja
```

Podemos acceder al primer elemento:

```csharp
Console.WriteLine(frutas[0]);
```

Resultado:

```text
Manzana
```

Al segundo:

```csharp
Console.WriteLine(frutas[1]);
```

Resultado:

```text
Banana
```

---

# Modificar un elemento

Los elementos también pueden modificarse.

```csharp
frutas[1] = "Pera";
```

Antes:

```text
0 → Manzana
1 → Banana
2 → Naranja
```

Después:

```text
0 → Manzana
1 → Pera
2 → Naranja
```

---

# Length

Podemos conocer la cantidad de elementos mediante:

```csharp
frutas.Length
```

Por ejemplo:

```csharp
Console.WriteLine(frutas.Length);
```

Resultado:

```text
3
```

`Length` será especialmente útil cuando recorramos arreglos.

---

# Recorrer un arreglo con for

En el capítulo anterior aprendimos el bucle:

```csharp
for
```

Ahora podemos combinar ambos conceptos:

```csharp
for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);
}
```

Tenemos:

```text
i = 0
↓
frutas[0]

i = 1
↓
frutas[1]

i = 2
↓
frutas[2]
```

Cuando:

```text
i = 3
```

la condición:

```csharp
i < frutas.Length
```

es falsa porque:

```text
3 < 3 → false
```

y el bucle termina.

---

# Cuidado con los índices

Si tenemos tres elementos:

```text
0
1
2
```

el último índice válido es:

```text
2
```

Intentar acceder a:

```csharp
frutas[3]
```

produce una excepción porque esa posición no existe.

Este es un error muy habitual cuando comenzamos a trabajar con arreglos.

---

# Crear un arreglo indicando su tamaño

También podemos escribir:

```csharp
string[] nombres = new string[3];
```

Esto crea espacio para tres elementos.

Después podemos asignarlos:

```csharp
nombres[0] = "Ana";
nombres[1] = "Juan";
nombres[2] = "Pedro";
```

---

# El tamaño es fijo

Una característica importante de los arreglos en C# es que su longitud se establece cuando se crean.

Por ejemplo:

```csharp
int[] numeros = new int[5];
```

tiene cinco posiciones.

Si necesitamos colecciones cuyo tamaño pueda crecer o reducirse dinámicamente, C# dispone de otras estructuras, como:

```csharp
List<T>
```

que veremos más adelante.

---

# Ejercicio

Crear un arreglo con cinco lenguajes:

```csharp
string[] lenguajes =
{
    "C#",
    "Python",
    "JavaScript",
    "SQL",
    "HTML"
};
```

Después:

1. Mostrar el primer elemento.
2. Mostrar el último.
3. Mostrar la cantidad con `Length`.
4. Recorrer todo el arreglo utilizando `for`.

---

# Desafío

Crear un arreglo:

```csharp
int[] numeros =
{
    10,
    20,
    30,
    40,
    50
};
```

Utilizando un `for`, calcular la suma de todos sus elementos.

Podés comenzar con:

```csharp
int suma = 0;
```

y dentro del bucle:

```csharp
suma += numeros[i];
```

Al finalizar:

```csharp
Console.WriteLine($"Total: {suma}");
```

---

# Dato importante

Los índices comienzan desde:

```text
0
```

Por eso, si:

```csharp
frutas.Length
```

devuelve:

```text
3
```

los índices válidos son:

```text
0
1
2
```

No:

```text
1
2
3
```

---

# Resumen

Crear:

```csharp
string[] frutas =
{
    "Manzana",
    "Banana",
    "Naranja"
};
```

Acceder:

```csharp
frutas[0]
```

Modificar:

```csharp
frutas[1] = "Pera";
```

Cantidad:

```csharp
frutas.Length
```

Recorrer:

```csharp
for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);
}
```

Los arreglos nos permiten comenzar a trabajar con conjuntos de datos en lugar de variables individuales.
