using System.ComponentModel.DataAnnotations;
using EventPilot.Domain.Enum;

namespace EventPilot.Application.DTOs.Event;

public class UpdateEventDto: EventDto
{
    public bool? ClearTotalCapacity { get; set; } = false;
    public bool? ClearDescription { get; set; } = false;
}