using System.ComponentModel.DataAnnotations;
using EventPilot.Domain.Enum;

namespace EventPilot.Application.DTOs.Event;

public class PatchEventDto
{
    public string? Name {get; set;}
    
    public string? Location {get; set;}
    
    public string? Description {get; set;}
    public bool? ClearDescription { get; set; }
    
    public DateTime? StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    public int? TotalCapacity { get; set; }
    public bool? ClearTotalCapacity { get; set; }
    
    public EventStatus? Status { get; set; }
}