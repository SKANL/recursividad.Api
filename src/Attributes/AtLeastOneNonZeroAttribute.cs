using System.ComponentModel.DataAnnotations;
using recursividad.Api.Models.DTOs;

namespace recursividad.Api.Attributes;

// Se aplica a la clase, no a la propiedad
[AttributeUsage(AttributeTargets.Class)] 
public class AtLeastOneNonZeroAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is McdRequest request)
        {
            if (request.NumberA == 0 && request.NumberB == 0)
            {
                return new ValidationResult("Al menos uno de los dos números debe ser diferente de cero.");
            }
        }

        return ValidationResult.Success;
    }
}