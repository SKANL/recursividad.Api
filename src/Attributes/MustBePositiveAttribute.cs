using System.ComponentModel.DataAnnotations;

namespace recursividad.Api.Attributes;

public class MustBePositiveAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is not int number)
        {
            return new ValidationResult("El valor debe ser un número entero.");
        }

        if (number <= 0)
        {
            return new ValidationResult("El valor debe ser un número positivo (mayor que cero).");
        }

        return ValidationResult.Success;
    }
}