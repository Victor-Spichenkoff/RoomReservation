using EventPilot.Application.DTOs.Event;
using FluentValidation;

namespace EventPilot.Application.Validators.Event;

public class CreateEventDtoValidator: AbstractValidator<CreateEventDto>
{
    public CreateEventDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Inform a name");
        
        RuleFor(x => x.StartDate)
            .NotEmpty().NotNull().WithMessage("Inform a Start Date");
        
        RuleFor(x => x.EndDate)
            .NotEmpty().NotNull().WithMessage("Inform a End Date");
        
        RuleFor(x => x.Status)
            .NotEmpty().NotNull().WithMessage("Inform a Status");
    }
}
//
// public class CreateEventDtoValidator: EventBaseDtoValidator<CreateEventDto>
// {
//     public CreateEventDtoValidator()
//     {
//         RuleFor(x => x.Name)
//             .NotEmpty().WithMessage("inform a name");
//             
//
//         RuleFor(x => x.StartDate)
//             .NotEmpty().NotNull().WithMessage("Inform a Start Date");
//         
//         RuleFor(x => x.EndDate)
//             .NotEmpty().NotNull().WithMessage("Inform a End Date");
//         
//         RuleFor(x => x.Status)
//             .NotEmpty().NotNull().WithMessage("Inform a Status");
//         
//         ValidateName();
//         ValidateDescription();
//         ValidateDescription();
//     }
// }