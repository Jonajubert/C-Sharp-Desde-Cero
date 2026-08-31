# C# Desde Cero

## Capítulo 007 - Switch

En el capítulo anterior aprendimos a utilizar:

```csharp
if
else if
else
```

para tomar decisiones.

Ahora conoceremos otra estructura de selección disponible en C#:

```csharp
switch
```

---

# ¿Qué aprenderás?

En este capítulo veremos:

- Qué es `switch`.
- Cómo utilizar `case`.
- Para qué sirve `break`.
- Cómo utilizar `default`.
- Cómo crear un menú.
- Diferencias básicas entre `switch` e `if`.

---

# ¿Qué es switch?

`switch` permite evaluar una expresión y ejecutar diferentes bloques según el valor obtenido.

Por ejemplo:

```csharp
int opcion = 2;

switch (opcion)
{
    case 1:
        Console.WriteLine("Opción 1");
        break;

    case 2:
        Console.WriteLine("Opción 2");
        break;

    default:
        Console.WriteLine("Opción incorrecta");
        break;
}
```

Resultado:

```text
Opción 2
```

---

# La estructura

Podemos separar un `switch` en cuatro conceptos principales:

```text
switch
   ↓
Valor que evaluamos

case
   ↓
Posible coincidencia

break
   ↓
Finaliza ese caso

default
   ↓
Ningún case coincidió
```

---

# switch

Primero indicamos qué queremos evaluar:

```csharp
switch (opcion)
{
}
```

En este ejemplo evaluamos el contenido de:

```csharp
opcion
```

---

# case

Dentro del `switch` podemos definir diferentes casos:

```csharp
case 1:
    Console.WriteLine("Consultar saldo");
    break;
```

Podemos leerlo como:

```text
Si opcion coincide con 1
          ↓
ejecutar este código
```

Después podemos agregar más casos:

```csharp
case 2:
    Console.WriteLine("Realizar transferencia");
    break;

case 3:
    Console.WriteLine("Salir");
    break;
```

---

# break

En este ejemplo utilizamos:

```csharp
break;
```

para finalizar la ejecución del `switch` después de ejecutar el código correspondiente al caso.

```csharp
case 1:
    Console.WriteLine("Consultar saldo");
    break;
```

Podemos visualizarlo así:

```text
case 1
   │
   ▼
Ejecutar código
   │
   ▼
 break
   │
   ▼
Salir del switch
```

---

# default

¿Qué ocurre si el usuario escribe:

```text
8
```

y solamente tenemos:

```text
case 1
case 2
case 3
```

Podemos utilizar:

```csharp
default:
    Console.WriteLine("Opción incorrecta");
    break;
```

`default` cubre el caso en que ninguna de las alternativas anteriores coincide.

Es conceptualmente similar al papel que suele cumplir `else` al final de una cadena condicional.

---

# Ejemplo completo

```csharp
internal class Program
{
    static void Main(string[] args)
    {
        int opcion;

        Console.WriteLine("=== MENÚ PRINCIPAL ===");
        Console.WriteLine("1 - Consultar saldo");
        Console.WriteLine("2 - Realizar transferencia");
        Console.WriteLine("3 - Salir");

        Console.Write("Seleccione una opción: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Consultando saldo...");
                break;

            case 2:
                Console.WriteLine("Iniciando transferencia...");
                break;

            case 3:
                Console.WriteLine("Saliendo del programa...");
                break;

            default:
                Console.WriteLine("Opción incorrecta.");
                break;
        }
    }
}
```

---

# Flujo del programa

Supongamos:

```text
opcion = 2
```

Entonces:

```text
                 opcion
                    │
                    ▼
                 switch
                    │
       ┌────────────┼────────────┐
       │            │            │
       ▼            ▼            ▼
    case 1       case 2       case 3
      NO            SÍ
                     │
                     ▼
               Transferencia
                     │
                     ▼
                   break
```

---

# switch vs if

Las dos estructuras permiten tomar decisiones, pero no siempre resultan igual de claras.

## if

Es muy útil para condiciones:

```csharp
if (edad >= 18)
```

o:

```csharp
if (nota >= 6 && asistencia >= 75)
```

Podemos trabajar con rangos y expresiones booleanas complejas.

---

## switch

Resulta muy cómodo cuando queremos evaluar alternativas concretas:

```text
1
2
3
4
```

Por ejemplo:

```csharp
switch (opcion)
{
    case 1:
        ...

    case 2:
        ...

    case 3:
        ...
}
```

---

# Comparación

Podemos pensar inicialmente:

```text
¿Necesito evaluar una condición o rango?

edad >= 18
nota >= 6
temperatura < 10

        ↓

       if
```

Mientras que:

```text
¿Tengo un valor con varias
alternativas concretas?

opcion = 1, 2 o 3

        ↓

      switch
```

No es una regla absoluta, pero es una buena forma de comenzar a entender cuándo cada estructura puede resultar más clara.

---

# Ejercicio

Crear un programa que muestre:

```text
=== CALCULADORA ===

1 - Sumar
2 - Restar
3 - Multiplicar
4 - Dividir
```

Después solicitar:

```text
Seleccione una operación:
```

y utilizar:

```csharp
switch
```

para mostrar qué operación seleccionó el usuario.

Por ahora no hace falta realizar el cálculo.

Ejemplo:

```text
Seleccione una operación: 3

Seleccionaste multiplicar.
```

---

# Desafío extra

En lugar de números, crear:

```csharp
string dia;
```

y evaluar:

```text
lunes
martes
miércoles
...
```

utilizando `switch`.

---

# Dato importante

`switch` no reemplaza automáticamente a `if`.

La estructura adecuada depende del problema.

```text
CONDICIONES / RANGOS
        ↓
       if

VALORES CONCRETOS
        ↓
      switch
```

El objetivo no es utilizar la estructura más sofisticada.

Es escribir código claro y fácil de mantener.

---

# Próximo capítulo

Ya podemos tomar decisiones utilizando diferentes estructuras de control.

A medida que avancemos empezaremos a controlar también la repetición de instrucciones dentro de nuestros programas.
