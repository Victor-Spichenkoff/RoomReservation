using EventPilot.Domain.Enum;

namespace EventPilot.Domain.Entities;

public class SessionRegistration
{
    public long SessionId { get; set; }
    public Session Session { get; set; } = null!;
    
    public long EventRegistrationId { get; set; }
    public EventRegistration EventRegistration { get; set; } = null!;
    
    public DateTime RegistrationDate { get; set; }
    public SessionRegistrationStatus Status { get; set; }
}