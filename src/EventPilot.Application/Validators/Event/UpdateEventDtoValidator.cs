using EventPilot.Application.DTOs.Event;
using FluentValidation;

namespace EventPilot.Application.Validators.Event;

public class UpdateEventDtoValidator : EventBaseDtoValidator<UpdateEventDto>
{
    public UpdateEventDtoValidator()
    {
        SetRequiredFieldsValidationOn();
    
        
        ValidateName();
        ValidateDescription();
        ValidateDescription();
        ValidateStatus();
        ValidateEndDateBiggerThanStartDate();
    }
    
}