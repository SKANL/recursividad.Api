using Microsoft.AspNetCore.Mvc;
using recursividad.Api.Models.DTOs;
using recursividad.Api.Services.Contracts;

namespace recursividad.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PuzzlesController : ControllerBase
{
    private readonly IPuzzleService _puzzleService;

    public PuzzlesController(IPuzzleService puzzleService)
    {
        _puzzleService = puzzleService;
    }

    // --- Endpoint para Ejercicio 4: Cambio de Monedas ---
    [HttpPost("change-making")]
    public IActionResult GetMinimumChange([FromBody] ChangeMakingRequest request)
    {
        try
        {
            var response = _puzzleService.CalculateMinimumChange(request.AmountDue, request.AmountPaid);
            return Ok(response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // --- Endpoint para Ejercicio 5: Torres de Hanói (Nuevo) ---
    [HttpPost("towers-of-hanoi")]
    public IActionResult GetHanoiSolution([FromBody] HanoiRequest request)
    {
        try
        {
            var response = _puzzleService.SolveTowersOfHanoi(request.NumberOfDisks);
            return Ok(response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}