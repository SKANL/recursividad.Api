using recursividad.Api.Models.DTOs;
using recursividad.Api.Services.Contracts;

namespace recursividad.Api.Services;

public class PuzzleService : IPuzzleService
{
    // --- Ejercicio 4: Cambio de Monedas ---
    private readonly List<(string Name, int ValueInCents)> _denominations = new()
    {
        ("100 pesos", 10000), ("50 pesos", 5000), ("20 pesos", 2000),
        ("10 pesos", 1000), ("5 pesos", 500), ("1 peso", 100),
        ("50 centavos", 50), ("20 centavos", 20), ("1 centavo", 1)
    };

    public ChangeMakingResponse CalculateMinimumChange(decimal amountDue, decimal amountPaid)
    {
        if (amountPaid < amountDue)
        {
            throw new ArgumentException("El monto pagado no puede ser menor al monto a pagar.");
        }

        var totalChange = amountPaid - amountDue;
        var totalChangeInCents = (long)(totalChange * 100);

        var breakdown = new Dictionary<string, int>();
        CalculateChangeRecursive(totalChangeInCents, 0, breakdown);

        return new ChangeMakingResponse(totalChange, breakdown);
    }

    private void CalculateChangeRecursive(long remainingCents, int denominationIndex, Dictionary<string, int> breakdown)
    {
        if (remainingCents == 0 || denominationIndex >= _denominations.Count)
        {
            return;
        }

        var currentDenomination = _denominations[denominationIndex];
        var coinCount = (int)(remainingCents / currentDenomination.ValueInCents);
        breakdown.Add(currentDenomination.Name, coinCount);
        var newRemainingCents = remainingCents % currentDenomination.ValueInCents;
        CalculateChangeRecursive(newRemainingCents, denominationIndex + 1, breakdown);
    }

    // --- Ejercicio 5: Torres de Hanói ---
    public HanoiResponse SolveTowersOfHanoi(int numberOfDisks)
    {
        if (numberOfDisks <= 0)
        {
            throw new ArgumentException("El número de discos debe ser positivo.");
        }

        var moves = new List<string>();
        // Las varillas se nombran A (Origen), B (Auxiliar), C (Destino)
        HanoiRecursive(numberOfDisks, 'A', 'C', 'B', moves);

        return new HanoiResponse(moves);
    }

    private void HanoiRecursive(int n, char source, char destination, char auxiliary, List<string> moves)
    {
        // Caso Base: Si solo hay un disco, muévelo directamente del origen al destino.
        if (n == 1)
        {
            moves.Add($"Mover disco 1 de {source} a {destination}");
            return;
        }

        // Paso Recursivo 1: Mover n-1 discos del origen al auxiliar, usando el destino como pivote.
        HanoiRecursive(n - 1, source, auxiliary, destination, moves);

        // Mover el disco más grande (n) que quedó en el origen, al destino.
        moves.Add($"Mover disco {n} de {source} a {destination}");

        // Paso Recursivo 2: Mover los n-1 discos que dejamos en el auxiliar, al destino, usando el origen como pivote.
        HanoiRecursive(n - 1, auxiliary, destination, source, moves);
    }
}