# Documentación de la API de Ejercicios de Recursividad

Esta API está diseñada para resolver diferentes problemas matemáticos y de lógica usando técnicas recursivas. La API es fácil de usar y está pensada para ayudarte a resolver varios tipos de cálculos de manera rápida y eficiente.

## ¿Qué es esta API?

Esta API te permite resolver 9 ejercicios diferentes relacionados con matemáticas y lógica. Solo necesitas enviar los datos que quieres calcular y la API te devuelve la respuesta correcta.

---

## Ejercicio 1: Factorial de un Número

### ¿Qué hace este ejercicio?
Calcula el factorial de un número. El factorial es el resultado de multiplicar un número por todos los números menores que él hasta llegar a 1.

**Ejemplo:** El factorial de 5 (se escribe como 5!) es: 5 × 4 × 3 × 2 × 1 = 120

### ¿Cómo usar este ejercicio?

**Dirección:** `POST /api/Math/factorial`

**Datos que necesitas enviar:**
```json
{
  "Number": 5
}
```

**Respuesta que recibirás:**
```json
{
  "Result": 120
}
```

### Pasos para probarlo:

1. **Abre tu herramienta favorita** para probar APIs (como Postman o Thunder Client)
2. **Selecciona POST** como método
3. **Escribe la dirección:** `http://localhost:5250/api/Math/factorial`
4. **En el cuerpo (Body)** selecciona "JSON" y escribe:
   ```json
   {
     "Number": 5
   }
   ```
5. **Presiona Enviar**

### Validaciones y mensajes de error:

❌ **Si envías un número negativo:**
- **Error:** "El valor no puede ser negativo."
- **Solución:** Introduce solo números desde 0 en adelante

❌ **Si no envías un número:**
- **Error:** "El valor debe ser un número entero."
- **Solución:** Asegúrate de enviar solo números enteros

---

## Ejercicio 2: Secuencia de Fibonacci

### ¿Qué hace este ejercicio?
Genera una secuencia de números donde cada número es la suma de los dos anteriores. Comienza con 0 y 1.

**Ejemplo:** Los primeros 7 números de Fibonacci son: 0, 1, 1, 2, 3, 5, 8

### ¿Cómo usar este ejercicio?

**Dirección:** `POST /api/Math/fibonacci`

**Datos que necesitas enviar:**
```json
{
  "Count": 7
}
```

**Respuesta que recibirás:**
```json
{
  "Sequence": [0, 1, 1, 2, 3, 5, 8]
}
```

### Pasos para probarlo:

1. **Selecciona POST** como método
2. **Escribe la dirección:** `http://localhost:5250/api/Math/fibonacci`
3. **En el cuerpo (Body)** escribe:
   ```json
   {
     "Count": 10
   }
   ```
4. **Presiona Enviar**

### Validaciones y mensajes de error:

❌ **Si envías cero o un número negativo:**
- **Error:** "El valor debe ser un número positivo (mayor que cero)."
- **Solución:** Introduce solo números mayores a cero

---

## Ejercicio 3: Máximo Común Divisor (MCD)

### ¿Qué hace este ejercicio?
Encuentra el número más grande que puede dividir exactamente a dos números dados.

**Ejemplo:** El MCD de 48 y 18 es 6, porque 6 es el número más grande que divide exactamente tanto a 48 como a 18.

### ¿Cómo usar este ejercicio?

**Dirección:** `POST /api/Math/mcd`

**Datos que necesitas enviar:**
```json
{
  "NumberA": 48,
  "NumberB": 18
}
```

**Respuesta que recibirás:**
```json
{
  "Result": 6
}
```

### Pasos para probarlo:

1. **Selecciona POST** como método
2. **Escribe la dirección:** `http://localhost:5250/api/Math/mcd`
3. **En el cuerpo (Body)** escribe:
   ```json
   {
     "NumberA": 24,
     "NumberB": 16
   }
   ```
4. **Presiona Enviar**

### Validaciones y mensajes de error:

❌ **Si ambos números son cero:**
- **Error:** "Al menos uno de los dos números debe ser diferente de cero."
- **Solución:** Asegúrate de que al menos uno de los números no sea cero

---

## Ejercicio 4: Cambio de Monedas

### ¿Qué hace este ejercicio?
Calcula cuántas monedas y billetes necesitas para dar el cambio exacto cuando alguien paga más de lo que debe.

**Ejemplo:** Si algo cuesta $23.50 y pagas con $50, necesitas devolver $26.50 en cambio.

### ¿Cómo usar este ejercicio?

**Dirección:** `POST /api/Puzzles/change-making`

**Datos que necesitas enviar:**
```json
{
  "AmountDue": 23.50,
  "AmountPaid": 50.00
}
```

**Respuesta que recibirás:**
```json
{
  "TotalChange": 26.50,
  "CoinBreakdown": {
    "20 pesos": 1,
    "5 pesos": 1,
    "1 peso": 1,
    "50 centavos": 1,
    "100 pesos": 0,
    "50 pesos": 0,
    "10 pesos": 0,
    "20 centavos": 0,
    "1 centavo": 0
  }
}
```

### Pasos para probarlo:

1. **Selecciona POST** como método
2. **Escribe la dirección:** `http://localhost:5250/api/Puzzles/change-making`
3. **En el cuerpo (Body)** escribe:
   ```json
   {
     "AmountDue": 15.75,
     "AmountPaid": 20.00
   }
   ```
4. **Presiona Enviar**

### Validaciones y mensajes de error:

❌ **Si pagas menos de lo que debes:**
- **Error:** "El monto pagado debe ser mayor or igual al monto adeudado."
- **Solución:** Asegúrate de que el monto pagado sea igual o mayor al monto que debes

❌ **Si algún monto es negativo:**
- **Error:** "El valor no puede ser negativo."
- **Solución:** Introduce solo números positivos para los montos

---

## Ejercicio 5: Torres de Hanói

### ¿Qué hace este ejercicio?
Resuelve el famoso rompecabezas de las Torres de Hanói. Este juego consiste en mover discos de diferentes tamaños de una torre a otra, siguiendo estas reglas:
- Solo puedes mover un disco a la vez
- Un disco grande nunca puede estar encima de uno más pequeño

### ¿Cómo usar este ejercicio?

**Dirección:** `POST /api/Puzzles/towers-of-hanoi`

**Datos que necesitas enviar:**
```json
{
  "NumberOfDisks": 3
}
```

**Respuesta que recibirás:**
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

### Pasos para probarlo:

1. **Selecciona POST** como método
2. **Escribe la dirección:** `http://localhost:5250/api/Puzzles/towers-of-hanoi`
3. **En el cuerpo (Body)** escribe:
   ```json
   {
     "NumberOfDisks": 4
   }
   ```
4. **Presiona Enviar**

### Validaciones y mensajes de error:

❌ **Si el número de discos es cero o negativo:**
- **Error:** "El valor debe ser un número positivo (mayor que cero)."
- **Solución:** Introduce solo números mayores a cero

---

## Ejercicio 6: Potencia de un Número

### ¿Qué hace este ejercicio?
Calcula el resultado de elevar un número a una potencia específica.

**Ejemplo:** 2 elevado a la 3 (2³) = 2 × 2 × 2 = 8

### ¿Cómo usar este ejercicio?

**Dirección:** `POST /api/Math/potencia`

**Datos que necesitas enviar:**
```json
{
  "Base": 2,
  "Exponente": 3
}
```

**Respuesta que recibirás:**
```json
{
  "Result": 8
}
```

### Pasos para probarlo:

1. **Selecciona POST** como método
2. **Escribe la dirección:** `http://localhost:5250/api/Math/potencia`
3. **En el cuerpo (Body)** escribe:
   ```json
   {
     "Base": 5,
     "Exponente": 2
   }
   ```
4. **Presiona Enviar**

### Validaciones y mensajes de error:

❌ **Si la base o el exponente son negativos:**
- **Error:** "El valor no puede ser negativo."
- **Solución:** Introduce solo números positivos o cero

---

## Ejercicio 7: Suma de los Dígitos de un Número

### ¿Qué hace este ejercicio?
Suma todos los dígitos que forman un número.

**Ejemplo:** Los dígitos de 123 son 1, 2 y 3. Su suma es: 1 + 2 + 3 = 6

### ¿Cómo usar este ejercicio?

**Dirección:** `POST /api/Math/suma-digitos`

**Datos que necesitas enviar:**
```json
{
  "Numbers": 123
}
```

**Respuesta que recibirás:**
```json
{
  "Result": 6
}
```

### Pasos para probarlo:

1. **Selecciona POST** como método
2. **Escribe la dirección:** `http://localhost:5250/api/Math/suma-digitos`
3. **En el cuerpo (Body)** escribe:
   ```json
   {
     "Numbers": 9876
   }
   ```
4. **Presiona Enviar**

### Nota importante:
Este ejercicio funciona con números positivos y negativos. Si envías un número negativo, solo sumará los dígitos (ignorando el signo negativo).

---

## Ejercicio 8: Invertir un Número Entero

### ¿Qué hace este ejercicio?
Invierte el orden de los dígitos de un número.

**Ejemplo:** Si tienes el número 123, el resultado será 321

### ¿Cómo usar este ejercicio?

**Dirección:** `POST /api/Math/invertir-numero`

**Datos que necesitas enviar:**
```json
{
  "Number": 123
}
```

**Respuesta que recibirás:**
```json
{
  "Result": 321
}
```

### Pasos para probarlo:

1. **Selecciona POST** como método
2. **Escribe la dirección:** `http://localhost:5250/api/Math/invertir-numero`
3. **En el cuerpo (Body)** escribe:
   ```json
   {
     "Number": 5678
   }
   ```
4. **Presiona Enviar**

### Nota importante:
Si envías un número negativo, el resultado mantendrá el signo negativo. Por ejemplo: -123 se convierte en -321

---

## Ejercicio 9: Suma de los Primeros N Números Enteros

### ¿Qué hace este ejercicio?
Suma todos los números enteros desde 1 hasta el número que especifiques.

**Ejemplo:** Los primeros 5 números enteros son 1, 2, 3, 4, 5. Su suma es: 1 + 2 + 3 + 4 + 5 = 15

### ¿Cómo usar este ejercicio?

**Dirección:** `POST /api/Math/suma-primeros-n`

**Datos que necesitas enviar:**
```json
{
  "N": 5
}
```

**Respuesta que recibirás:**
```json
{
  "Result": 15
}
```

### Pasos para probarlo:

1. **Selecciona POST** como método
2. **Escribe la dirección:** `http://localhost:5250/api/Math/suma-primeros-n`
3. **En el cuerpo (Body)** escribe:
   ```json
   {
     "N": 10
   }
   ```
4. **Presiona Enviar**

### Validaciones y mensajes de error:

❌ **Si el número es negativo:**
- **Error:** "El valor no puede ser negativo."
- **Solución:** Introduce solo números positivos o cero

---

## Consejos Generales para Usar la API

### ✅ Datos Correctos
- Siempre envía números enteros donde se requiera
- Usa números positivos cuando se indique
- Verifica que todos los campos requeridos tengan valores

### ❌ Errores Comunes
- **"Introduce sólo números":** Ocurre cuando envías texto en lugar de números
- **"Hay datos faltantes":** Ocurre cuando no envías todos los campos requeridos
- **"El valor no puede ser negativo":** Ocurre cuando envías números negativos donde no están permitidos
- **"El valor debe ser un número positivo":** Ocurre cuando envías cero o números negativos donde se requieren números mayores a cero

### 🔧 Solución de Problemas
1. **Verifica el formato JSON:** Asegúrate de que la estructura sea correcta
2. **Revisa los tipos de datos:** Usa números enteros, no texto
3. **Confirma la dirección:** Verifica que la URL sea correcta
4. **Método HTTP:** Siempre usa POST para todos los ejercicios

### 📋 Ejemplo de Respuesta de Error
```json
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "errors": {
    "Number": ["El valor no puede ser negativo."]
  }
}
```

---

## ¿Cómo Empezar?

1. **Ejecuta la API** en tu computadora
2. **Abre una herramienta** para probar APIs (Postman, Thunder Client, etc.)
3. **Selecciona el ejercicio** que quieres probar
4. **Copia la dirección** correspondiente
5. **Envía los datos** en formato JSON
6. **Revisa la respuesta** y verifica que sea correcta

¡Ya estás listo para usar todos los ejercicios de recursividad!