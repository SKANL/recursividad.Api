using recursividad.Api.Attributes;

namespace recursividad.Api.Models.DTOs;

// --- Ejercicio 4: Cambio de Monedas ---

[SufficientPayment]
public record ChangeMakingRequest( [MustBeNonNegative] decimal AmountDue, [MustBeNonNegative] decimal AmountPaid);
public record ChangeMakingResponse(decimal TotalChange, Dictionary<string, int> CoinBreakdown);



// --- Ejercicio 5: Torres de Hanói ---

public record HanoiRequest( [MustBePositive] int NumberOfDisks);
public record HanoiResponse(List<string> Moves);