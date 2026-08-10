# C# Desde Cero

## Capítulo 004 - Entrada y salida de datos

Hasta ahora nuestros programas utilizaban valores definidos directamente en el código.

En este capítulo comenzaremos a interactuar con el usuario utilizando la consola.

---

# ¿Qué aprenderás?

- Cómo mostrar información.
- Cómo recibir información del usuario.
- Cómo utilizar `Console.WriteLine()`.
- Cómo utilizar `Console.ReadLine()`.
- Cómo convertir texto a números.
- Cómo utilizar interpolación de cadenas.

---

# Salida de datos

Para mostrar información en la consola podemos utilizar:

```csharp
Console.WriteLine("Hola mundo");
```

El resultado será:

```text
Hola mundo
```

---

# WriteLine y Write

También podemos utilizar:

```csharp
Console.Write("Nombre: ");
```

La diferencia principal es que `WriteLine()` agrega un salto de línea después del texto.

```csharp
Console.WriteLine("Hola");
Console.WriteLine("Mundo");
```

Resultado:

```text
Hola
Mundo
```

Mientras que:

```csharp
Console.Write("Hola ");
Console.Write("Mundo");
```

produce:

```text
Hola Mundo
```

---

# Entrada de datos

Para leer información ingresada por el usuario utilizamos:

```csharp
Console.ReadLine();
```

Por ejemplo:

```csharp
Console.Write("Ingresá tu nombre: ");

string nombre = Console.ReadLine() ?? "";
```

El programa se detendrá en ese punto hasta que el usuario escriba algo y presione Enter.

---

# ¿Qué devuelve ReadLine?

`Console.ReadLine()` devuelve texto.

Por ejemplo, aunque escribamos:

```text
30
```

el valor recibido inicialmente es una cadena de caracteres.

Si necesitamos trabajar con ese valor como un número debemos convertirlo.

---

# Convertir texto a int

Podemos utilizar:

```csharp
int edad = int.Parse(Console.ReadLine() ?? "0");
```

Ahora `edad` es un `int` y podemos realizar operaciones matemáticas con ella.

---

# Interpolación de cadenas

C# permite insertar variables directamente dentro de un texto utilizando `$`.

```csharp
string nombre = "Jonatan";
int edad = 30;

Console.WriteLine($"Hola, {nombre}. Tenés {edad} años.");
```

Resultado:

```text
Hola, Jonatan. Tenés 30 años.
```

---

# Flujo del programa

Nuestro programa ahora sigue este proceso:

```text
USUARIO
   ↓
Console.ReadLine()
   ↓
VARIABLE
   ↓
PROCESAMIENTO
   ↓
Console.WriteLine()
   ↓
RESULTADO
```

Este patrón aparecerá constantemente cuando construyamos programas más completos.

---

# Ejercicio

Modificar el programa para solicitar:

- Nombre.
- Edad.
- Ciudad.

Guardar cada dato en una variable.

Luego mostrar:

```text
=== PERFIL ===

Nombre: Jonatan
Edad: 30
Ciudad: Eldorado
```

Como desafío adicional, solicitar dos números y mostrar su suma.

---

# Dato importante

`Console.ReadLine()` devuelve texto.

Por eso, cuando necesitamos trabajar con números debemos convertir el valor recibido.

En este capítulo utilizamos:

```csharp
int.Parse()
```

Más adelante aprenderemos una forma más segura utilizando:

```csharp
int.TryParse()
```

---

# Próximo capítulo

## Condicionales: if y else

Utilizaremos los datos ingresados por el usuario para hacer que nuestro programa pueda tomar decisiones.
