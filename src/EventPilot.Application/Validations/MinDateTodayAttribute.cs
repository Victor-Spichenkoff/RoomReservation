using System.ComponentModel.DataAnnotations;

namespace EventPilot.Application.Validations;

public sealed class MinDateTodayAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dateTimeValue)
        {
            // Lógica de validação: a data deve ser maior ou igual à data de hoje
            if (dateTimeValue.Date >= DateTime.Today)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ErrorMessage ?? "A data deve ser igual ou posterior à data de hoje.");
            }
        }
        // Se o campo for opcional e nulo, a validação é bem-sucedida (o atributo [Required] lida com campos obrigatórios)
        return ValidationResult.Success;
    }
}