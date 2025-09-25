using System.ComponentModel.DataAnnotations;
using recursividad.Api.Models.DTOs;

namespace recursividad.Api.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class SufficientPaymentAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is ChangeMakingRequest request)
        {
            if (request.AmountPaid < request.AmountDue)
            {
                return new ValidationResult("El monto pagado debe ser mayor or igual al monto adeudado.");
            }
        }

        return ValidationResult.Success;
    }
}