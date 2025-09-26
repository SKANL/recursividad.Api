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
                var result = _mathService.CalculateFactorial(request.Number);
                var response = new FactorialResponse(result);
                return Ok(response);
        }

        // --- Endpoint para Ejercicio 2: Fibonacci ---
        [HttpPost("fibonacci")]
        public IActionResult GetFibonacci([FromBody] FibonacciRequest request)
        {
                var result = _mathService.GenerateFibonacci(request.Count);
                var response = new FibonacciResponse(result);
                return Ok(response);
        }

        // --- Endpoint para Ejercicio 3: MCD ---
        [HttpPost("mcd")]
        public IActionResult GetMcd([FromBody] McdRequest request)
        {
                var result = _mathService.CalculateMcd(request.NumberA, request.NumberB);
                var response = new McdResponse(result);
                return Ok(response);
        }

        // --- Endpoint para Ejercicio 6: Potencia de un número ---
        [HttpPost("potencia")]
        public IActionResult GetPotenciaDeUnNumero([FromBody] PotenciaDeUnNumeroRequest request)
        {
                var result = _mathService.CalculatePotenciaDeUnNumero(request.Base, request.Exponente);
                var response = new PotenciaDeUnNumeroResponse(result);
                return Ok(response);
        }

        // --- Endpoint para Ejercicio 7: Suma de los dígitos de un número ---
        [HttpPost("suma-digitos")]
        public IActionResult GetSumaDigitos([FromBody] SumaDigitosRequest request)
        {
                var result = _mathService.CalculateSumaDigitos(request.Numbers);
                var response = new SumaDigitosResponse(result);
                return Ok(response);
        }

        // --- Endpoint para Ejercicio 8: Invertir un numero entero ---
        [HttpPost("invertir-numero")]
        public IActionResult InvertirNumeroEntero([FromBody] InvertirNumeroEnteroRequest request)
        {
                var result = _mathService.InvertirNumeroEntero(request.Number);
                var response = new InvertirNumeroEnteroResponse(result);
                return Ok(response);
        }

        // --- Endpoint para Ejercicio 9: Suma de los primeros N numeros enteros ---
        [HttpPost("suma-primeros-n")]
        public IActionResult GetSumaPrimerosNNumerosEnteros([FromBody] SumaPrimerosNNumerosEnterosRequest request)
        {
                var result = _mathService.CalculateSumaPrimerosNNumerosEnteros(request.N);
                var response = new SumaPrimerosNNumerosEnterosResponse(result);
                return Ok(response);
        }
}