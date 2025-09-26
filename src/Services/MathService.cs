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

    // --- Ejercicio 6: Potencia de un número ---
    public long CalculatePotenciaDeUnNumero(int Base, int Exponente)
    {
        if (Exponente < 0)
        {
            throw new ArgumentException("El exponente no puede ser negativo.");
        }
        return PotenciaRecursive(Base, Exponente);
    }

    private long PotenciaRecursive(int Base, int Exponente)
    {
        // Caso Base: Cualquier número elevado a 0 es 1
        if (Exponente == 0) return 1;
        // Paso Recursivo
        return Base * PotenciaRecursive(Base, Exponente - 1);
    }

    // --- Ejercicio 7: Suma de los dígitos de un número ---
    public int CalculateSumaDigitos(int Numbers)
    {
        // Usamos el valor absoluto para manejar números negativos
        return SumaDigitosRecursive(Math.Abs(Numbers));
    }
    private int SumaDigitosRecursive(int n)
    {
        // Caso Base: Si el número es 0, la suma de sus dígitos es 0
        if (n == 0) return 0;
        // Paso Recursivo: Sumar el último dígito y llamar recursivamente con el resto del número
        return (n % 10) + SumaDigitosRecursive(n / 10);
    }

    // --- Ejercicio 8: Invertir un número entero ---
    public int InvertirNumeroEntero(int Number)
    {
        // Usamos el valor absoluto para manejar números negativos
        int sign = Number < 0 ? -1 : 1;
        return sign * InvertirNumeroRecursive(Math.Abs(Number), 0);
    }
    private int InvertirNumeroRecursive(int n, int reversed)
    {
        // Caso Base: Si el número es 0, devolvemos el número invertido
        if (n == 0) return reversed;
        // Paso Recursivo: Tomar el último dígito y agregarlo al número invertido
        return InvertirNumeroRecursive(n / 10, reversed * 10 + n % 10);
    }

    // --- Ejercicio 9: Suma de los primeros N números enteros ---
    public int CalculateSumaPrimerosNNumerosEnteros(int N)
    {
        if (N < 0)
        {
            throw new ArgumentException("N no puede ser negativo.");
        }
        return SumaPrimerosNNumerosRecursive(N);
    }
    private int SumaPrimerosNNumerosRecursive(int n)
    {
        // Caso Base: La suma de los primeros 0 números es 0
        if (n == 0) return 0;
        // Paso Recursivo: Sumar n y llamar recursivamente con n-1
        return n + SumaPrimerosNNumerosRecursive(n - 1);
    }
}