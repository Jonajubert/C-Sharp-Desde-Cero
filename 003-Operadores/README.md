# C# Desde Cero

# 📖 Capítulo 003

# Operadores

Hasta ahora aprendimos a almacenar información utilizando variables.

Ahora veremos cómo trabajar con esos datos mediante operadores.

Los operadores permiten realizar cálculos, comparar valores y evaluar condiciones.

---

# 🎯 ¿Qué aprenderás?

- Qué es un operador.
- Operadores aritméticos.
- Operadores de comparación.
- Operadores lógicos.
- Cuándo utilizar cada uno.

---

# Operadores aritméticos

Se utilizan para realizar cálculos.

| Operador | Descripción |
|----------|-------------|
| + | Suma |
| - | Resta |
| * | Multiplicación |
| / | División |
| % | Resto de una división |

Ejemplo:

```csharp
int resultado = 20 + 10;
```

---

# Operadores de comparación

Devuelven un valor booleano (`true` o `false`).

| Operador | Significado |
|----------|-------------|
| == | Igual |
| != | Distinto |
| > | Mayor |
| < | Menor |
| >= | Mayor o igual |
| <= | Menor o igual |

Ejemplo:

```csharp
20 > 10
```

Resultado:

```
true
```

---

# Operadores lógicos

Permiten combinar condiciones.

| Operador | Descripción |
|----------|-------------|
| && | AND |
| \|\| | OR |
| ! | NOT |

Ejemplo:

```csharp
true && false
```

Resultado:

```
false
```

---

# Resultado esperado

```
=== OPERADORES EN C# ===

Suma: 30
Resta: 10
Multiplicación: 200
División: 2

¿20 es mayor que 10? True
¿20 es igual a 10? False

true && false = False
true || false = True
!true = False
```

---

# 💡 Ejercicio

Crear dos variables enteras.

Mostrar:

- Suma.
- Resta.
- Multiplicación.
- División.

Luego comparar ambos números utilizando:

- >
- <
- ==

Finalmente probar los operadores:

- &&
- ||
- !

---

# 📌 ¿Sabías que?

Los operadores de comparación y los operadores lógicos serán fundamentales cuando comencemos a trabajar con estructuras de decisión como `if` y `switch`.

---

# 🚀 Próximo capítulo

**Entrada y salida de datos**

Aprenderemos a utilizar `Console.ReadLine()` para recibir información del usuario.
