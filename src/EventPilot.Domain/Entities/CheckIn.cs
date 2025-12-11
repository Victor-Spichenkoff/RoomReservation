using EventPilot.Domain.Enum;

namespace EventPilot.Domain.Entities;

public class CheckIn
{
    //IDs and navigation here
    public long SessionId { get; set; }
    public Session Session { get; set; } = null!;

    public long RegistrationId { get; set; }
    public Registration Registration { get; set; } = null!;
    
    
    // extra data here
    public DateTime CheckInDate { get; set; }
    public CheckInOrigin CheckInOrigin { get; set; }
    

    

    
}