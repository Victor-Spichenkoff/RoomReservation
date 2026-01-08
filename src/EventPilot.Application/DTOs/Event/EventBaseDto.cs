using System.ComponentModel.DataAnnotations;
using EventPilot.Application.Validations;
using EventPilot.Domain.Enum;

namespace EventPilot.Application.DTOs.Event;


public abstract class EventBaseDto
{
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters long")]
    public string? Name { get; set; }
    
    [MinLength(2, ErrorMessage = "Location must be at least 2 characters long")]
    public string? Location { get; set; }
    
    [MinLength(2, ErrorMessage = "Description must be at least 2 characters long")]
    [MaxLength(250, ErrorMessage = "Description can't exceed 250 characters")]
    public string? Description { get; set; }
    
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "TotalCapacity must be a positive number")]
    public int? TotalCapacity { get; set; }

    [EnumDataType(typeof(EventStatus), ErrorMessage = "Invalid Status")]
    public EventStatus? Status { get; set; }
}