using System.ComponentModel.DataAnnotations;
using EventPilot.Application.Validations;
using EventPilot.Domain.Enum;

namespace EventPilot.Application.DTOs.Event;

public class CreateEventDto : EventBaseDto
{
    
    [Required(ErrorMessage = "Name is required")]
    public new string Name { get; set; }
    
    [Required(ErrorMessage = "Location is required")]
    public new string Location { get; set; }
    
    [Required(ErrorMessage = "Start Data is required")]
    [MinDateToday(ErrorMessage = "Start can't be in the past")]
    public new DateTime StartDate { get; set; }

    [Required(ErrorMessage = "End Date is required")]
    public new DateTime? EndDate { get; set; }
    
    [Required]
    public new EventStatus? Status { get; set; }
}


// public class CreateEventDto
// {
//     
//     public string? Name {get; set;}
//     
//     
//     public string? Location {get; set;}
//     
//     
//     public string? Description {get; set;}
//     
//     
//     public DateTime? StartDate { get; set; }
//     
//     
//     public DateTime? EndDate { get; set; }
//     
//     public int? TotalCapacity { get; set; }
//     
//     
//     public EventStatus? Status { get; set; }
// }
// public class CreateEventDto
// {
//     [Required(ErrorMessage = "Name is required")]
//     public string? Name {get; set;}
//     
//     [Required(ErrorMessage = "Name is required")]
//     public string? Location {get; set;}
//     
//     [MaxLength(250, ErrorMessage = "Description can't be more than 250 characters")]
//     public string? Description {get; set;}
//     
//     [Required(ErrorMessage = "Start date is required")]
//     public DateTime? StartDate { get; set; }
//     
//     [Required(ErrorMessage = "End date is required")]
//     public DateTime? EndDate { get; set; }
//     
//     public int? TotalCapacity { get; set; }
//     
//     [Required(ErrorMessage = "Status is required")]
//     public EventStatus? Status { get; set; }
// }