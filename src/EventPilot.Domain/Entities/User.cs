using EventPilot.Domain.Enum;

namespace EventPilot.Domain.Entities;

public class User
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public string Password { get; set; } = String.Empty;
    public Roles Role { get; set; } = Roles.User;
    
    public ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();
    public ICollection<OrganizerEvent> OrganizerEvents { get; set; } = new List<OrganizerEvent>();
}