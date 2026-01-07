using EventPilot.Application.DTOs.Event;
using FluentValidation;

namespace EventPilot.Application.Validators.Event;

public class CreateEventDtoValidator: AbstractValidator<CreateEventDto>
{
    public CreateEventDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);
        
        RuleFor(x => x.Description)
            .MaximumLength(250)
            .WithMessage("Description must be less than 250 characters");

        RuleFor(x => x.StartDate)
            .NotEmpty().NotNull().WithMessage("Inform a Start Date");
        
        RuleFor(x => x.EndDate)
            .NotEmpty().NotNull().WithMessage("Inform a End Date");
        
        RuleFor(x => x.Status)
            .NotEmpty().NotNull().WithMessage("Inform a Status");
    }
}