using EventPilot.Domain.Enum;

namespace EventPilot.Domain.Entities;

public class CheckIn
{
    public long SessionId { get; set; }
    public Session Session { get; set; } = null!;

    public long RegistrationId { get; set; }
    public EventRegistration EventRegistration { get; set; } = null!;
    
    // extra data
    public DateTime CheckInDate { get; set; }
    public CheckInOrigin CheckInOrigin { get; set; } = CheckInOrigin.Online;
}