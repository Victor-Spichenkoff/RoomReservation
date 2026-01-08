using System.ComponentModel.DataAnnotations;
using EventPilot.Domain.Enum;

namespace EventPilot.Application.DTOs.Event;

public class UpdateEventDto: EventBaseDto
{
    
    [Required(ErrorMessage = "Name is required")]
    public new string Name { get; set; }
    
    [Required(ErrorMessage = "Location is required")]
    public new string Location { get; set; }
    
    [Required(ErrorMessage = "Start Data is required")]
    public new DateTime StartDate { get; set; }

    [Required(ErrorMessage = "End Date is required")]
    public new DateTime? EndDate { get; set; }
    
    [Required]
    public new EventStatus? Status { get; set; }
    
    public bool ClearTotalCapacity { get; set; } = false;
    public bool ClearDescription { get; set; } = false;
}