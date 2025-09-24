using Microsoft.AspNetCore.Mvc;
using recursividad.Api.Models.DTOs;
using recursividad.Api.Services.Contracts;

namespace recursividad.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MathController : ControllerBase
{
    private readonly IMathService _mathService;

    public MathController(IMathService mathService)
    {
        _mathService = mathService;
    }

    // --- Endpoint para Ejercicio 1: Factorial ---
    [HttpPost("factorial")]
    public IActionResult GetFactorial([FromBody] FactorialRequest request)
    {
        try
        {
            var result = _mathService.CalculateFactorial(request.Number);
            var response = new FactorialResponse(result);
            return Ok(response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // --- Endpoint para Ejercicio 2: Fibonacci ---
    [HttpPost("fibonacci")]
    public IActionResult GetFibonacci([FromBody] FibonacciRequest request)
    {
        try
        {
            var result = _mathService.GenerateFibonacci(request.Count);
            var response = new FibonacciResponse(result);
            return Ok(response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // --- Endpoint para Ejercicio 3: MCD ---
    [HttpPost("mcd")]
    public IActionResult GetMcd([FromBody] McdRequest request)
    {
        try
        {
            var result = _mathService.CalculateMcd(request.NumberA, request.NumberB);
            var response = new McdResponse(result);
            return Ok(response);
        }
        catch (Exception ex)
        {
            // Atrapamos una excepción más genérica por si acaso
            return BadRequest(ex.Message);
        }
    }

    // --- Endpoint para Ejercicio 6: Potencia de un número ---
    [HttpPost("potencia")]
    public IActionResult GetPotenciaDeUnNumero([FromBody] PotenciaDeUnNumeroRequest request)
    {
        try
        {
            var result = _mathService.CalculatePotenciaDeUnNumero(request.Base, request.Exponente);
            var response = new PotenciaDeUnNumeroResponse(result);
            return Ok(response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}