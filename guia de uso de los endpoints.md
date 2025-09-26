# Guía de Uso de los Endpoints de la API

Esta guía te explica cómo usar cada uno de los endpoints disponibles en la API de ejercicios matemáticos. Cada endpoint resuelve un problema específico y te devuelve la respuesta que necesitas.

---

## Endpoint 1: Factorial de un Número

### Descripción del Problema
Necesitas calcular el factorial de un número. El factorial significa multiplicar ese número por todos los números menores que él hasta llegar a 1.

Por ejemplo: Si quieres el factorial de 4, tienes que hacer: 4 × 3 × 2 × 1 = 24

### Funcionamiento Paso a Paso
1. Envías un número entero positivo
2. La API multiplica ese número por todos los números menores hasta 1
3. Te devuelve el resultado final

### Información del Endpoint
- **Dirección:** `/api/Math/factorial`
- **Método:** POST (Crear/Enviar datos)

### Formato del Request (Lo que envías)
```json
{
  "Number": 5
}
```

### Formato del Response (Lo que recibes)
```json
{
  "Result": 120
}
```

---

## Endpoint 2: Secuencia de Fibonacci

### Descripción del Problema
Necesitas generar una secuencia de números donde cada número es la suma de los dos anteriores. La secuencia siempre comienza con 0 y 1.

Por ejemplo: Los primeros 6 números son: 0, 1, 1, 2, 3, 5

### Funcionamiento Paso a Paso
1. Envías cuántos números de la secuencia quieres
2. La API calcula cada número sumando los dos anteriores
3. Te devuelve la lista completa de números

### Información del Endpoint
- **Dirección:** `/api/Math/fibonacci`
- **Método:** POST (Crear/Enviar datos)

### Formato del Request (Lo que envías)
```json
{
  "Count": 8
}
```

### Formato del Response (Lo que recibes)
```json
{
  "Sequence": [0, 1, 1, 2, 3, 5, 8, 13]
}
```

---

## Endpoint 3: Máximo Común Divisor (MCD)

### Descripción del Problema
Necesitas encontrar el número más grande que puede dividir exactamente a dos números dados, sin dejar residuo.

Por ejemplo: Para los números 12 y 8, el MCD es 4 porque 4 divide exactamente tanto a 12 como a 8.

### Funcionamiento Paso a Paso
1. Envías dos números enteros
2. La API encuentra el divisor común más grande entre ellos
3. Te devuelve ese número

### Información del Endpoint
- **Dirección:** `/api/Math/mcd`
- **Método:** POST (Crear/Enviar datos)

### Formato del Request (Lo que envías)
```json
{
  "NumberA": 48,
  "NumberB": 18
}
```

### Formato del Response (Lo que recibes)
```json
{
  "Result": 6
}
```

---

## Endpoint 4: Cambio de Monedas

### Descripción del Problema
Necesitas calcular el cambio exacto cuando alguien paga más dinero del que debe, y quieres saber cuántas monedas y billetes usar para dar ese cambio.

Por ejemplo: Si algo cuesta $15.50 y pagan con $20.00, necesitas devolver $4.50 en cambio.

### Funcionamiento Paso a Paso
1. Envías el monto que se debe pagar y el monto que pagaron
2. La API calcula la diferencia (el cambio)
3. Te dice exactamente cuántas monedas y billetes de cada tipo necesitas

### Información del Endpoint
- **Dirección:** `/api/Puzzles/change-making`
- **Método:** POST (Crear/Enviar datos)

### Formato del Request (Lo que envías)
```json
{
  "AmountDue": 15.50,
  "AmountPaid": 20.00
}
```

### Formato del Response (Lo que recibes)
```json
{
  "TotalChange": 4.50,
  "CoinBreakdown": {
    "100 pesos": 0,
    "50 pesos": 0,
    "20 pesos": 0,
    "10 pesos": 0,
    "5 pesos": 0,
    "1 peso": 4,
    "50 centavos": 1,
    "20 centavos": 0,
    "1 centavo": 0
  }
}
```

---

## Endpoint 5: Torres de Hanói

### Descripción del Problema
Necesitas resolver el rompecabezas de las Torres de Hanói. Tienes tres torres (A, B, C) y varios discos de diferentes tamaños. Debes mover todos los discos de la torre A a la torre C, pero solo puedes mover un disco a la vez y nunca puedes poner un disco grande encima de uno pequeño.

### Funcionamiento Paso a Paso
1. Envías el número de discos que tienes
2. La API calcula todos los movimientos necesarios para resolver el puzzle
3. Te devuelve la lista paso a paso de cada movimiento

### Información del Endpoint
- **Dirección:** `/api/Puzzles/towers-of-hanoi`
- **Método:** POST (Crear/Enviar datos)

### Formato del Request (Lo que envías)
```json
{
  "NumberOfDisks": 3
}
```

### Formato del Response (Lo que recibes)
```json
{
  "Moves": [
    "Mover disco 1 de A a C",
    "Mover disco 2 de A a B",
    "Mover disco 1 de C a B",
    "Mover disco 3 de A a C",
    "Mover disco 1 de B a A",
    "Mover disco 2 de B a C",
    "Mover disco 1 de A a C"
  ]
}
```

---

## Endpoint 6: Potencia de un Número

### Descripción del Problema
Necesitas calcular el resultado de elevar un número (base) a una potencia específica (exponente).

Por ejemplo: 3 elevado a la potencia 4 significa: 3 × 3 × 3 × 3 = 81

### Funcionamiento Paso a Paso
1. Envías el número base y el exponente
2. La API multiplica la base por sí misma tantas veces como indique el exponente
3. Te devuelve el resultado final

### Información del Endpoint
- **Dirección:** `/api/Math/potencia`
- **Método:** POST (Crear/Enviar datos)

### Formato del Request (Lo que envías)
```json
{
  "Base": 2,
  "Exponente": 5
}
```

### Formato del Response (Lo que recibes)
```json
{
  "Result": 32
}
```

---

## Endpoint 7: Suma de los Dígitos de un Número

### Descripción del Problema
Necesitas sumar todos los dígitos individuales que forman un número.

Por ejemplo: Si tienes el número 456, los dígitos son 4, 5 y 6. La suma sería: 4 + 5 + 6 = 15

### Funcionamiento Paso a Paso
1. Envías un número entero
2. La API separa cada dígito del número
3. Suma todos los dígitos y te devuelve el total

### Información del Endpoint
- **Dirección:** `/api/Math/suma-digitos`
- **Método:** POST (Crear/Enviar datos)

### Formato del Request (Lo que envías)
```json
{
  "Numbers": 1234
}
```

### Formato del Response (Lo que recibes)
```json
{
  "Result": 10
}
```

---

## Endpoint 8: Invertir un Número Entero

### Descripción del Problema
Necesitas voltear un número, es decir, cambiar el orden de sus dígitos del final al principio.

Por ejemplo: Si tienes el número 789, el resultado sería 987

### Funcionamiento Paso a Paso
1. Envías un número entero
2. La API toma cada dígito y los reordena en sentido contrario
3. Te devuelve el número con los dígitos invertidos

### Información del Endpoint
- **Dirección:** `/api/Math/invertir-numero`
- **Método:** POST (Crear/Enviar datos)

### Formato del Request (Lo que envías)
```json
{
  "Number": 12345
}
```

### Formato del Response (Lo que recibes)
```json
{
  "Result": 54321
}
```

---

## Endpoint 9: Suma de los Primeros N Números Enteros

### Descripción del Problema
Necesitas sumar todos los números enteros consecutivos desde 1 hasta el número que especifiques.

Por ejemplo: Si especificas 4, necesitas sumar: 1 + 2 + 3 + 4 = 10

### Funcionamiento Paso a Paso
1. Envías un número entero (N)
2. La API suma todos los números desde 1 hasta N
3. Te devuelve el resultado total

### Información del Endpoint
- **Dirección:** `/api/Math/suma-primeros-n`
- **Método:** POST (Crear/Enviar datos)

### Formato del Request (Lo que envías)
```json
{
  "N": 10
}
```

### Formato del Response (Lo que recibes)
```json
{
  "Result": 55
}
```

---

## Información General sobre los Endpoints

### Todos los Endpoints Usan:
- **Método POST:** Para enviar información y recibir resultados
- **Formato JSON:** Tanto para enviar como para recibir datos
- **Respuestas Inmediatas:** Obtienes el resultado al instante

### Estructura Base de las URLs:
- **Endpoints Matemáticos:** `/api/Math/[nombre-del-ejercicio]`
- **Endpoints de Puzzles:** `/api/Puzzles/[nombre-del-ejercicio]`

### Qué Hacer si Algo No Funciona:
1. Verifica que estés usando el método POST
2. Asegúrate de que el formato JSON sea correcto
3. Revisa que todos los campos requeridos tengan valores
4. Confirma que los números sean del tipo correcto (enteros o decimales según corresponda)

¡Con esta guía ya puedes usar todos los endpoints de la API de manera efectiva!