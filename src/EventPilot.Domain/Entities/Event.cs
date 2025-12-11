using EventPilot.Domain.Enum;

namespace EventPilot.Domain.Entities;

public class Event
{
    public long Id { get; set; }
    public required long Name {get; set;}
    public required string Location {get; set;}
    public string? Description {get; set;}
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int TotalCapacity { get; set; }
    //TODO: CREATE THIS:
    public EventStatus Status { get; set; }
    public DateTime CreationDate { get; set; }
    
    
    public ICollection<Registration> Registrations { get; set; } = null!;
}