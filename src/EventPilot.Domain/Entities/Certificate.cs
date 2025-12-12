namespace EventPilot.Domain.Entities;

public class Certificate
{
    public long SessionId { get; set; }
    public Session Session { get; set; } = null!;
    
    public long EventRegistrationId { get; set; }
    public EventRegistration EventRegistration { get; set; } = null!;
    
    public DateTime GenerationDate { get; set; }
    public string VerificationCode { get; set; } = null!;
}