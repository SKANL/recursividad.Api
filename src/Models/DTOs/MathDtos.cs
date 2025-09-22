namespace recursividad.Api.Models.DTOs;

// Ejercicio 1: Factorial de un número

public record FactorialRequest(int Number); // Plantilla para la solicitud (lo que nos envía el usuario)
public record FactorialResponse(long Result); // Plantilla para la respuesta (lo que nosotros devolvemos)


// Ejercicio 2: Fibonacci
public record FibonacciRequest(int Count);
public record FibonacciResponse(List<long> Sequence);


// Ejercicio 3: Máximo Común Divisor (MCD)
public record McdRequest(int NumberA, int NumberB);
public record McdResponse(int Result);