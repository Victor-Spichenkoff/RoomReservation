using EventPilot.Application.DTOs.Event;
using FluentValidation;

namespace EventPilot.Application.Validators.Event;

public class PatchEventDtoValidator : EventBaseDtoValidator<EventBaseDto>
{
    public PatchEventDtoValidator()
    {
        When(x => x.Name != null, ValidateName);
        When(x => x.Description != null, ValidateDescription);
        When(x => x.Location != null, ValidateLocation);
        When(x => x.Status != null, ValidateStatus);
        When(x => x.EndDate != null && x.StartDate != null, ValidateEndDateBiggerThanStartDate);
        
    }
}