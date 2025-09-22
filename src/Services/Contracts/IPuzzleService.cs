using recursividad.Api.Models.DTOs;

namespace recursividad.Api.Services.Contracts;

public interface IPuzzleService
{
    ChangeMakingResponse CalculateMinimumChange(decimal amountDue, decimal amountPaid);
    HanoiResponse SolveTowersOfHanoi(int numberOfDisks);
}