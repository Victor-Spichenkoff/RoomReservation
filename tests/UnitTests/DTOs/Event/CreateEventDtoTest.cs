using EventPilot.Application.DTOs.Event;
using EventPilot.Application.Validators.Event;
using EventPilot.Domain.Enum;
using FluentAssertions;

namespace UnitTests.DTOs.Event;


public class CreateEventDtoTest
{
    
    [Fact]
    public void Should_Be_Valid_When_All_Fields_Are_Filled()
    {
        var dto = CreateValidEventBaseEventDto();
        var validator = new EventBaseDtoValidator<EventBaseDto>();
        
        var result = validator.Validate(dto);

        result.IsValid.Should().BeTrue();
    }
    
    [Fact]
    public void Should_Be_Valid_When_Nullable_Fields_Are_Null()
    {
        var dto = (CreateEventDto)CreateValidEventBaseEventDto();
        dto.Description = null;
        dto.TotalCapacity = null; 
        var validator = new CreateEventDtoValidator();
        
        var result = validator.Validate(dto);

        result.IsValid.Should().BeTrue();
    }
    
    
    [Fact]
    public void Should_Fail_When_Start_Date_Is_In_The_Past()
    {
        var dto = (CreateEventDto)CreateValidEventBaseEventDto();
        dto.StartDate = DateTime.Today.AddDays(-1);
        var validator = new CreateEventDtoValidator();
        
        var result = validator.Validate(dto);

        result.IsValid.Should().BeFalse();
        result.Errors.Should()
            .ContainSingle(e => e.PropertyName  == nameof(CreateEventDto.StartDate));
    }



    private static EventBaseDto CreateValidEventBaseEventDto()
    {
        return (EventBaseDto)(new CreateEventDto()
        {
            Name = "Test",
            StartDate = DateTime.Today,
            Description = "Test",
            Location = "Test",
            Status = (EventStatus?)1,
            EndDate = DateTime.Today.AddDays(1),
            TotalCapacity = 12
        });
    }
}