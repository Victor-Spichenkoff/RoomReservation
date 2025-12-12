using EventPilot.Domain.ValueObjects;

namespace EventPilot.Domain.Entities;

public class EventRegistration
{
    public long Id { get; set; }
    public DateTime RegistrationDate { get; set; }
    public Code Code { get; private set; }
    
    public long EventId { get; set; }
    public required Event Event { get; set; }
    public long UserId { get; set; }
    public required User User { get; set; }

    public ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
    public ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();
    public ICollection<SessionRegistration> SessionRegistrations { get; set; } = new List<SessionRegistration>();
    
    public EventRegistration(Code code)
    {
        Code = code;
    }
}