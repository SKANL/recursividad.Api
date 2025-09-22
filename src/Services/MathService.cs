using recursividad.Api.Services.Contracts;

namespace recursividad.Api.Services;

public class MathService : IMathService
{
    // --- Ejercicio 1: Factorial (Ya implementado) ---
    public long CalculateFactorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("El número no puede ser negativo.");
        }
        return FactorialRecursive(number);
    }

    private long FactorialRecursive(int n)
    {
        if (n == 0) return 1;
        return n * FactorialRecursive(n - 1);
    }

    // --- Ejercicio 2: Fibonacci ---
    public List<long> GenerateFibonacci(int count)
    {
        if (count <= 0)
        {
            throw new ArgumentException("La cantidad de elementos debe ser positiva.");
        }

        var series = new List<long>();
        for (int i = 0; i < count; i++)
        {
            series.Add(FibonacciRecursive(i));
        }
        return series;
    }

    private long FibonacciRecursive(int n)
    {
        // Casos Base: F(0) = 0, F(1) = 1
        if (n <= 1)
        {
            return n;
        }
        // Paso Recursivo: F(n) = F(n-1) + F(n-2)
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // --- Ejercicio 3: Máximo Común Divisor (MCD) ---
    public int CalculateMcd(int numberA, int numberB)
    {
        // Usamos el valor absoluto para manejar números negativos
        return McdRecursive(Math.Abs(numberA), Math.Abs(numberB));
    }

    private int McdRecursive(int a, int b)
    {
        // Caso Base: El MCD es 'a' cuando 'b' es 0 (Algoritmo de Euclides)
        if (b == 0)
        {
            return a;
        }
        // Paso Recursivo
        return McdRecursive(b, a % b);
    }
}