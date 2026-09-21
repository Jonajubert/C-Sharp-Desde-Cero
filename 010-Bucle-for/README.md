# C# Desde Cero

## Capítulo 010 - Bucle for

En capítulos anteriores aprendimos a utilizar:

```csharp
while
```

y:

```csharp
do-while
```

Ahora conoceremos otra estructura de repetición fundamental:

```csharp
for
```

El bucle `for` resulta especialmente útil cuando conocemos o podemos controlar la cantidad de iteraciones que queremos realizar.

---

# ¿Qué aprenderás?

- Qué es un bucle `for`.
- Cómo funciona.
- Qué es la inicialización.
- Qué es la condición.
- Qué es la actualización.
- Cómo incrementar y decrementar.
- Cómo recorrer un arreglo.
- Diferencias básicas con `while`.

---

# Nuestro primer for

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Número: {i}");
}
```

Resultado:

```text
Número: 1
Número: 2
Número: 3
Número: 4
Número: 5
```

---

# Las tres partes del for

La estructura:

```csharp
for (int i = 1; i <= 5; i++)
```

contiene tres partes principales.

## 1. Inicialización

```csharp
int i = 1
```

Creamos la variable de control y establecemos su valor inicial.

---

## 2. Condición

```csharp
i <= 5
```

Mientras esta condición sea verdadera, el bucle continúa.

---

## 3. Actualización

```csharp
i++
```

Después de cada iteración incrementamos `i`.

Podemos visualizarlo:

```text
for (
     int i = 1;
     i <= 5;
     i++
    )

       │
       │
       ├── Inicialización
       ├── Condición
       └── Actualización
```

---

# Paso a paso

Comenzamos:

```text
i = 1
```

Evaluamos:

```text
1 <= 5 → true
```

Ejecutamos el bloque:

```text
Número: 1
```

Después:

```csharp
i++;
```

Ahora:

```text
i = 2
```

El proceso continúa.

---

# Todas las iteraciones

```text
i = 1
1 <= 5 → true
Número: 1

i = 2
2 <= 5 → true
Número: 2

i = 3
3 <= 5 → true
Número: 3

i = 4
4 <= 5 → true
Número: 4

i = 5
5 <= 5 → true
Número: 5

i = 6
6 <= 5 → false

FIN
```

---

# Flujo

```text
INICIALIZACIÓN
      │
      ▼
  ¿CONDICIÓN?
      │
 ┌────┴────┐
 │         │
true      false
 │         │
 ▼         ▼
CÓDIGO     FIN
 │
 ▼
ACTUALIZACIÓN
 │
 └────────────→ volver a la condición
```

---

# Contar hacia atrás

No siempre tenemos que incrementar.

Podemos utilizar:

```csharp
i--
```

Ejemplo:

```csharp
for (int i = 5; i >= 1; i--)
{
    Console.WriteLine(i);
}
```

Resultado:

```text
5
4
3
2
1
```

Tenemos:

```text
i = 5
↓
i >= 1
↓
i--
```

En cada iteración disminuimos el contador.

---

# Recorrer un arreglo

También podemos utilizar `for` para recorrer elementos.

```csharp
string[] frutas =
{
    "Manzana",
    "Banana",
    "Naranja",
    "Uva"
};
```

Nuestro arreglo contiene cuatro elementos.

Podemos recorrerlo:

```csharp
for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);
}
```

---

# ¿Por qué comenzamos en 0?

Los índices de un arreglo comienzan en:

```text
0
```

Por ejemplo:

```text
ÍNDICE       ELEMENTO

0            Manzana
1            Banana
2            Naranja
3            Uva
```

Por eso utilizamos:

```csharp
int i = 0;
```

---

# Length

La propiedad:

```csharp
frutas.Length
```

indica la cantidad de elementos.

En nuestro ejemplo:

```text
frutas.Length = 4
```

Entonces utilizamos:

```csharp
i < frutas.Length
```

Tenemos:

```text
i = 0 → válido
i = 1 → válido
i = 2 → válido
i = 3 → válido
i = 4 → termina
```

---

# for vs while

Con `while` podríamos escribir:

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

Con `for`:

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

Ambos pueden producir el mismo resultado.

Pero `for` reúne:

```text
Inicialización
Condición
Actualización
```

en una sola estructura.

---

# ¿Cuándo usar for?

Como primera aproximación:

```text
FOR
↓
Cuando conocemos o controlamos
la cantidad de iteraciones.
```

Mientras que:

```text
WHILE
↓
Cuando la repetición depende
principalmente de una condición.
```

No es una regla absoluta, pero es una buena referencia mientras aprendemos.

---

# Una curiosidad

La idea de los bucles controlados por contador existe desde los primeros lenguajes de programación.

La sintaxis clásica:

```text
inicialización;
condición;
actualización
```

se popularizó especialmente con la familia de lenguajes influenciados por C.

Por eso podemos encontrar estructuras muy similares en:

```text
C
C++
C#
Java
JavaScript
```

Aprender esta estructura facilita posteriormente la lectura de otros lenguajes.

---

# Ejercicio

Utilizando `for`, mostrar:

```text
1
2
3
4
5
6
7
8
9
10
```

Después modificarlo para mostrar:

```text
10
9
8
7
6
5
4
3
2
1
```

Pensá qué debe cambiar:

```text
Inicialización
Condición
Actualización
```

---

# Desafío

Calculá la suma de los números del 1 al 100.

Podés comenzar con:

```csharp
int suma = 0;
```

y utilizar:

```csharp
for (int i = 1; i <= 100; i++)
{
    // Acumular el valor de i.
}
```

Al finalizar, mostrar el resultado utilizando:

```csharp
Console.WriteLine($"Resultado: {suma}");
```

---

# Dato importante

El `for` reúne tres elementos:

```text
INICIALIZACIÓN
       +
CONDICIÓN
       +
ACTUALIZACIÓN
```

Por ejemplo:

```csharp
for (int i = 1; i <= 5; i++)
```

Siempre revisá especialmente la condición.

Una condición incorrecta puede provocar que el bucle se ejecute una cantidad inesperada de veces o que nunca termine.

---

# Resumen

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

se puede interpretar como:

```text
Comenzar con i = 1
        ↓
¿i <= 5?
        ↓
Ejecutar código
        ↓
Incrementar i
        ↓
Volver a comprobar
```

El bucle `for` será una herramienta fundamental cuando necesitemos controlar repeticiones y recorrer colecciones de datos.
