namespace recursividad.Api.Models.DTOs;

// --- Ejercicio 4: Cambio de Monedas ---

public record ChangeMakingRequest(decimal AmountDue, decimal AmountPaid);
public record ChangeMakingResponse(decimal TotalChange, Dictionary<string, int> CoinBreakdown);



// --- Ejercicio 5: Torres de Hanói ---

public record HanoiRequest(int NumberOfDisks);
public record HanoiResponse(List<string> Moves);