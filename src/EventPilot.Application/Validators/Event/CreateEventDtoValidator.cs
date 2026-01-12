using EventPilot.Application.DTOs.Event;
using FluentValidation;

namespace EventPilot.Application.Validators.Event;




public class CreateEventDtoValidator: EventBaseDtoValidator<EventDto>
{
    public CreateEventDtoValidator()
    {
        SetRequiredFieldsValidationOn();
        
        
        RuleFor(x => x.StartDate)
            .GreaterThan(DateTime.Now).WithMessage("Start Date can't be in the past");
        
        
        ValidateName();
        ValidateDescription();
        ValidateDescription();
        ValidateStatus();
        ValidateEndDateBiggerThanStartDate();
    }
}