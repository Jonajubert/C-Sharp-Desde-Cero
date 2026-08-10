# C# Desde Cero

## Capítulo 004 - Entrada y salida de datos

Hasta ahora utilizamos variables cuyos valores estaban escritos directamente dentro del código.

En este capítulo aprenderemos a hacer que el usuario pueda ingresar información utilizando la consola.

---

# ¿Qué aprenderás?

- Cómo declarar una variable.
- Cómo mostrar información en la consola.
- Cómo solicitar información al usuario.
- Cómo leer información utilizando `Console.ReadLine()`.
- Cómo guardar el dato ingresado en una variable.
- Cómo mostrar posteriormente ese dato.

---

# 1. Declarar una variable

Antes de guardar el nombre del usuario necesitamos una variable.

```csharp
string nombre;
```

En este caso utilizamos:

```text
string
```

porque queremos almacenar texto.

La variable se llama:

```text
nombre
```

Todavía no contiene ningún valor.

---

# 2. Solicitar información

Ahora necesitamos indicarle al usuario qué información debe ingresar.

Utilizamos:

```csharp
Console.Write("Escriba su nombre: ");
```

La consola mostrará:

```text
Escriba su nombre:
```

El programa todavía no está leyendo información.

Solamente estamos mostrando un mensaje.

---

# 3. Leer información

Para leer lo que escribe el usuario utilizamos:

```csharp
Console.ReadLine();
```

Pero además necesitamos guardar esa información.

Por eso escribimos:

```csharp
nombre = Console.ReadLine();
```

Ahora el contenido ingresado por el usuario queda almacenado en la variable `nombre`.

---

# 4. Mostrar la información

Una vez almacenado el dato podemos utilizarlo.

Primero mostramos:

```csharp
Console.Write("Hola: ");
```

Después mostramos nuestra variable:

```csharp
Console.Write(nombre);
```

Si el usuario escribió:

```text
Jonatan
```

obtendremos:

```text
Hola: Jonatan
```

---

# Código completo

```csharp
internal class Program
{
    static void Main(string[] args)
    {
        // Declaramos la variable.
        string nombre;

        // Solicitamos el dato.
        Console.Write("Escriba su nombre: ");

        // Leemos y almacenamos el dato.
        nombre = Console.ReadLine();

        // Mostramos el resultado.
        Console.Write("Hola: ");
        Console.Write(nombre);
    }
}
```

---

# ¿Cómo funciona?

Podemos pensar nuestro programa en cuatro pasos:

```text
1. DECLARAR

string nombre;

        ↓

2. SOLICITAR

Console.Write("Escriba su nombre: ");

        ↓

3. LEER

nombre = Console.ReadLine();

        ↓

4. MOSTRAR

Console.Write(nombre);
```

---

# Console.Write()

Utilizamos:

```csharp
Console.Write();
```

para mostrar información en la consola.

Por ejemplo:

```csharp
Console.Write("Hola");
```

Resultado:

```text
Hola
```

---

# Console.ReadLine()

Utilizamos:

```csharp
Console.ReadLine();
```

para leer una línea de texto ingresada por el usuario.

Por ejemplo:

```csharp
nombre = Console.ReadLine();
```

El programa espera a que el usuario escriba algo y presione **Enter**.

El texto ingresado se guarda en `nombre`.

---

# ¿Write o WriteLine?

También existe:

```csharp
Console.WriteLine();
```

La diferencia es sencilla.

`Write` mantiene el cursor en la misma línea:

```csharp
Console.Write("Hola ");
Console.Write("Jonatan");
```

Resultado:

```text
Hola Jonatan
```

Mientras que `WriteLine` agrega un salto de línea:

```csharp
Console.WriteLine("Hola");
Console.WriteLine("Jonatan");
```

Resultado:

```text
Hola
Jonatan
```

---

# Ejercicio

Modificar el programa para solicitar también la ciudad.

Primero declarar las variables:

```csharp
string nombre;
string ciudad;
```

Luego pedir ambos datos al usuario.

El resultado debería ser similar a:

```text
Escriba su nombre: Jonatan
Escriba su ciudad: Eldorado

Hola: Jonatan
Ciudad: Eldorado
```

---

# Dato importante

`Console.ReadLine()` permite leer texto ingresado desde la consola.

Por ahora trabajaremos únicamente con `string`.

Más adelante aprenderemos cómo recibir números y convertir el texto ingresado a tipos como:

```csharp
int
double
decimal
```

De esta manera incorporaremos los conceptos progresivamente.

---

# Próximo capítulo

Continuaremos utilizando los datos ingresados por el usuario para construir programas más completos.
