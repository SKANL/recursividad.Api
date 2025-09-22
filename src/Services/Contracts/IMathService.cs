namespace recursividad.Api.Services.Contracts;

public interface IMathService
{
    long CalculateFactorial(int number);
    List<long> GenerateFibonacci(int count);
    int CalculateMcd(int numberA, int numberB);
}