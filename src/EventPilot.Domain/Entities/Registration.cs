using EventPilot.Domain.ValueObjects;

namespace EventPilot.Domain.Entities;

public class Registration
{
    public long Id { get; set; }
    public DateTime RegistrationDate { get; set; }
    public Code Code { get; private set; }
    
    public long EventId { get; set; }
    public required Event Event { get; set; }
    public long UserId { get; set; }
    public required User User { get; set; }

    
    
    public Registration(Code code)
    {
        Code = code;
    }
}