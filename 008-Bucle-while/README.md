# C# Desde Cero

## Capítulo 008 - Bucle while

Hasta ahora aprendimos a crear variables, realizar operaciones y tomar decisiones.

En este capítulo comenzaremos a trabajar con otra estructura fundamental de programación:

**los bucles.**

Un bucle nos permite ejecutar un bloque de código repetidamente.

Comenzaremos con:

```csharp
while
```

---

# ¿Qué aprenderás?

- Qué es un bucle.
- Cómo funciona `while`.
- Qué es una condición de repetición.
- Cómo utilizar un contador.
- Cómo incrementar una variable.
- Qué es un bucle infinito.
- Cuándo puede resultar útil utilizar `while`.

---

# ¿Qué es un bucle?

Un bucle permite repetir instrucciones.

Por ejemplo, podríamos escribir:

```csharp
Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
Console.WriteLine(4);
Console.WriteLine(5);
```

Pero estamos repitiendo la misma operación.

Con un bucle podemos automatizar esa repetición.

---

# El bucle while

La estructura básica es:

```csharp
while (condicion)
{
    // Código que queremos repetir.
}
```

Podemos leerla como:

```text
MIENTRAS la condición sea verdadera
              ↓
      ejecutar el código
```

Después de ejecutar el bloque, C# vuelve a evaluar la condición.

---

# Nuestro primer while

```csharp
int contador = 1;

while (contador <= 5)
{
    Console.WriteLine(contador);
    contador++;
}
```

Resultado:

```text
1
2
3
4
5
```

---

# Los tres elementos

Para entender este ejemplo podemos identificar tres partes.

## 1. Estado inicial

```csharp
int contador = 1;
```

Nuestro contador comienza en:

```text
1
```

---

## 2. Condición

```csharp
contador <= 5
```

Mientras esta expresión sea:

```text
true
```

el bucle continuará ejecutándose.

---

## 3. Actualización

```csharp
contador++;
```

Después de cada repetición incrementamos el contador.

Podemos interpretarlo como:

```csharp
contador = contador + 1;
```

---

# Paso a paso

Al comenzar:

```text
contador = 1
```

C# evalúa:

```text
1 <= 5 → true
```

Ejecuta:

```csharp
Console.WriteLine(contador);
```

y muestra:

```text
1
```

Después:

```csharp
contador++;
```

Ahora:

```text
contador = 2
```

C# vuelve al `while` y evalúa nuevamente la condición.

---

# Todas las iteraciones

```text
contador = 1
1 <= 5 → true
imprime 1

contador = 2
2 <= 5 → true
imprime 2

contador = 3
3 <= 5 → true
imprime 3

contador = 4
4 <= 5 → true
imprime 4

contador = 5
5 <= 5 → true
imprime 5

contador = 6
6 <= 5 → false

FIN
```

---

# Flujo del while

Podemos visualizarlo así:

```text
        INICIO
          │
          ▼
    contador = 1
          │
          ▼
   ¿contador <= 5?
          │
     ┌────┴────┐
     │         │
   true      false
     │         │
     ▼         ▼
  imprimir    FIN
     │
     ▼
 contador++
     │
     └──────────→ volver a evaluar
```

---

# El operador ++

En nuestro ejemplo utilizamos:

```csharp
contador++;
```

Este operador incrementa el valor en una unidad.

Si:

```text
contador = 3
```

después de:

```csharp
contador++;
```

tenemos:

```text
contador = 4
```

En este contexto podemos entender:

```csharp
contador++;
```

como una forma compacta de:

```csharp
contador = contador + 1;
```

---

# Cuidado con los bucles infinitos

Observemos este código:

```csharp
int contador = 1;

while (contador <= 5)
{
    Console.WriteLine(contador);
}
```

Tenemos un problema.

El valor de:

```csharp
contador
```

nunca cambia.

Por lo tanto:

```text
1 <= 5 → true
1 <= 5 → true
1 <= 5 → true
1 <= 5 → true
...
```

El programa continúa repitiendo el bloque.

Esto se denomina:

```text
BUCLE INFINITO
```

---

# ¿Cómo lo evitamos?

Necesitamos que algo haga que eventualmente la condición sea falsa.

En nuestro ejemplo:

```csharp
contador++;
```

provoca:

```text
1
2
3
4
5
6
```

Cuando llegamos a:

```text
6 <= 5
```

obtenemos:

```text
false
```

y el bucle termina.

---

# Una pregunta importante

Antes de escribir un `while`, preguntate:

```text
¿Qué hará que esta condición
eventualmente se vuelva falsa?
```

Si la respuesta es:

```text
Nada
```

debemos revisar nuestro código.

---

# Ejemplo completo

```csharp
internal class Program
{
    static void Main(string[] args)
    {
        int contador = 1;

        while (contador <= 5)
        {
            Console.WriteLine(contador);

            contador++;
        }

        Console.WriteLine("Fin del programa.");
    }
}
```

---

# Ejercicio

Creá una cuenta regresiva utilizando `while`.

El programa debe mostrar:

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
¡Despegue!
```

Podés comenzar con:

```csharp
int contador = 10;
```

Pensá:

```text
¿cuál será la condición?

¿cómo tendremos que modificar
el contador en cada repetición?
```

---

# Desafío extra

Creá un programa que solicite números hasta que el usuario ingrese:

```text
0
```

Mientras el número sea diferente de cero, mostrar:

```text
Número ingresado: X
```

Cuando ingrese cero:

```text
Programa finalizado.
```

---

# Dato importante

Un `while` continúa ejecutándose mientras su condición sea verdadera.

Por eso debemos controlar:

```text
ESTADO INICIAL
      ↓
CONDICIÓN
      ↓
ACTUALIZACIÓN
```

Si la condición nunca se vuelve falsa, tendremos un bucle infinito.

---

# Próximo capítulo

Ya podemos repetir instrucciones utilizando una condición.

Esto nos permitirá automatizar procesos y construir programas con comportamientos cada vez más interesantes.
