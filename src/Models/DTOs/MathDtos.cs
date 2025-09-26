using recursividad.Api.Attributes;

namespace recursividad.Api.Models.DTOs;

// Ejercicio 1: Factorial de un número

public record FactorialRequest( [MustBeNonNegative] int Number); // Plantilla para la solicitud (lo que nos envía el usuario)
public record FactorialResponse(long Result); // Plantilla para la respuesta (lo que nosotros devolvemos)


// Ejercicio 2: Fibonacci
public record FibonacciRequest( [MustBePositive] int Count);
public record FibonacciResponse(List<long> Sequence);


// Ejercicio 3: Máximo Común Divisor (MCD)
[AtLeastOneNonZero]
public record McdRequest(int NumberA, int NumberB);
public record McdResponse(int Result);

// Ejercicio 6: Potencia de un número
public record PotenciaDeUnNumeroRequest( [MustBeNonNegative] int Base, [MustBeNonNegative] int Exponente);
public record PotenciaDeUnNumeroResponse(long Result);

// Ejerccicio 7: Suma de los dígitos de un número
public record SumaDigitosRequest(int Numbers);
public record SumaDigitosResponse(int Result);

// Ejercicio 8: Invertir un numero entero
public record InvertirNumeroEnteroRequest(int Number);
public record InvertirNumeroEnteroResponse(int Result);

// Ejertcicio 9: Suma de los primeros N numeros enteros
public record SumaPrimerosNNumerosEnterosRequest([MustBeNonNegative] int N);
public record SumaPrimerosNNumerosEnterosResponse(int Result);