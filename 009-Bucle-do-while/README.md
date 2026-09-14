# C# Desde Cero

## Capítulo 009 - Bucle do-while

En el capítulo anterior aprendimos a repetir instrucciones utilizando:

```csharp
while
```

Ahora conoceremos:

```csharp
do-while
```

Ambas estructuras utilizan una condición para controlar la repetición, pero existe una diferencia fundamental:

**`do-while` ejecuta el bloque al menos una vez.**

---

# ¿Qué aprenderás?

- Qué es `do-while`.
- Cómo funciona.
- Cómo escribir su sintaxis.
- Cuándo se evalúa la condición.
- Diferencia entre `while` y `do-while`.
- Por qué el bloque se ejecuta al menos una vez.
- Cómo evitar bucles infinitos.

---

# Sintaxis

La estructura básica es:

```csharp
do
{
    // Código que queremos ejecutar.
}
while (condicion);
```

Observá que la condición aparece después del bloque.

También debemos escribir:

```text
;
```

al final del `while`.

---

# Primer ejemplo

```csharp
int contador = 1;

do
{
    Console.WriteLine($"Número: {contador}");

    contador++;
}
while (contador <= 5);
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

# ¿Cómo funciona?

Primero tenemos:

```csharp
int contador = 1;
```

Después entramos directamente al bloque:

```csharp
do
{
    Console.WriteLine($"Número: {contador}");
    contador++;
}
```

Recién después se evalúa:

```csharp
contador <= 5
```

Si la condición es verdadera:

```text
true
```

el programa vuelve al `do`.

Si es falsa:

```text
false
```

el bucle termina.

---

# Flujo

```text
       INICIO
          │
          ▼
      EJECUTAR
       BLOQUE
          │
          ▼
      ACTUALIZAR
          │
          ▼
    ¿CONDICIÓN?
       │     │
      Sí     No
       │     │
       │     └────→ FIN
       │
       └──────────→ volver al do
```

La primera ejecución ocurre antes de comprobar la condición.

---

# Paso a paso

Con:

```csharp
int contador = 1;
```

tenemos:

```text
Ejecuta
↓
Muestra 1
↓
contador = 2
↓
2 <= 5 → true
↓
Repite
```

Después:

```text
Muestra 2
contador = 3
3 <= 5 → true
```

El proceso continúa hasta:

```text
Muestra 5
contador = 6
6 <= 5 → false
```

Entonces termina.

---

# La diferencia fundamental

Veamos este ejemplo:

```csharp
int numero = 10;

do
{
    Console.WriteLine($"Número: {numero}");
}
while (numero <= 5);
```

La condición es:

```text
10 <= 5
```

Por lo tanto:

```text
false
```

Sin embargo, el resultado es:

```text
Número: 10
```

Esto ocurre porque el bloque se ejecutó antes de evaluar la condición.

---

# while vs do-while

## while

```csharp
while (condicion)
{
    // Código
}
```

Flujo:

```text
CONDICIÓN
    ↓
¿true?
    ↓
EJECUTAR
```

Si la condición inicialmente es falsa:

```text
0 ejecuciones
```

---

## do-while

```csharp
do
{
    // Código
}
while (condicion);
```

Flujo:

```text
EJECUTAR
    ↓
CONDICIÓN
```

Aunque la condición inicialmente sea falsa:

```text
mínimo 1 ejecución
```

---

# Comparación

```text
WHILE
──────────────
Primero evalúa
la condición.

Puede ejecutarse
0 veces.


DO-WHILE
──────────────
Primero ejecuta
el bloque.

Se ejecuta
al menos 1 vez.
```

---

# Cuidado con el punto y coma

La sintaxis correcta es:

```csharp
do
{
    Console.WriteLine("Hola");
}
while (condicion);
```

Observá:

```text
while (condicion);
                 ↑
```

El punto y coma forma parte de la sintaxis de `do-while`.

---

# Bucle infinito

Al igual que con `while`, debemos asegurarnos de que la condición pueda volverse falsa.

Por ejemplo:

```csharp
int contador = 1;

do
{
    Console.WriteLine(contador);
}
while (contador <= 5);
```

`contador` nunca cambia.

Entonces:

```text
1 <= 5 → true
1 <= 5 → true
1 <= 5 → true
...
```

Tenemos un bucle infinito.

La solución sería actualizar el contador:

```csharp
contador++;
```

---

# ¿Cuándo usar do-while?

Es útil cuando necesitamos ejecutar primero una acción y después decidir si debemos repetirla.

Conceptualmente:

```text
HACER ALGO
     ↓
¿DEBEMOS REPETIR?
```

Por ejemplo:

```text
Mostrar menú
     ↓
Usuario elige opción
     ↓
¿Desea continuar?
```

---

# Ejercicio

Creá una cuenta utilizando:

```csharp
do-while
```

que muestre:

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

Comenzá con:

```csharp
int numero = 1;
```

Después definí:

- La actualización.
- La condición de salida.

---

# Desafío

Creá una cuenta regresiva:

```text
5
4
3
2
1
¡Despegue!
```

utilizando `do-while`.

Pensá qué operador necesitás utilizar para disminuir el contador.

---

# Dato importante

La diferencia esencial es:

```text
while
↓
CONDICIÓN → EJECUCIÓN


do-while
↓
EJECUCIÓN → CONDICIÓN
```

Por eso `do-while` siempre ejecuta su bloque al menos una vez.

---

# Resumen

```csharp
int contador = 1;

do
{
    Console.WriteLine($"Número: {contador}");
    contador++;
}
while (contador <= 5);
```

Podemos leerlo como:

```text
Ejecutar
   ↓
Incrementar
   ↓
Comprobar condición
   ↓
¿true?
   ↓
Repetir
```
