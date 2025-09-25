using System.ComponentModel.DataAnnotations;

namespace recursividad.Api.Attributes;

public class MustBeNonNegativeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null) return ValidationResult.Success; // La regla [Required] se encargaría de esto.

        // Hacemos que funcione para varios tipos numéricos
        var number = Convert.ToDecimal(value);

        if (number < 0)
        {
            return new ValidationResult("El valor no puede ser negativo.");
        }

        return ValidationResult.Success;
    }
}