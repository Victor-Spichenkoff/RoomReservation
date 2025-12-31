namespace EventPilot.Application.DTOs.Event;

public class UpdateEventDto: CreateEventDto
{
    public bool? ClearTotalCapacity { get; set; }
    public bool? ClearDescription { get; set; }
}